﻿using System;
using System.Threading.Tasks;
using FluentAssertions;
using Game.Common.Contracts.Items;
using Game.Common.Contracts.World.Tiles;
using Game.Common.Creatures;
using Game.Common.Item;
using Game.Common.Location;
using Game.Common.Location.Structs;
using Game.Items;
using Game.Items.Bases;
using Game.Tests.Helpers;
using Game.Tests.Helpers.Map;
using Game.Tests.Server;
using Game.World.Models.Tiles;
using Server.Events.Creature;
using xRetry;
using Xunit;

namespace Game.Creatures.Tests.Monster;

public class MonsterWalkTest
{
    [RetryFact(100)]
    public void Monster_that_has_CanPushItems_flag_ignores_objects_in_the_way()
    {
        //arrange

        // --------------------------------------------------------------------------
        // |  Tile 1 (Monster is here) |  Tile 2 (object is here)  |  Tile 3 (Goal) |
        // --------------------------------------------------------------------------

        var itemType = new ItemType
        {
            Flags = { ItemFlag.BlockPathFind }
        };

        var item = new Item(itemType, new Location(101, 100, 7));

        var destinationTile = new DynamicTile(new Coordinate(102, 100, 7), TileFlag.None,
            MapTestDataBuilder.CreateGround(new Location(102, 100, 7)), Array.Empty<IItem>(), null);

        var tiles = new ITile[]
        {
            new DynamicTile(new Coordinate(100, 100, 7), TileFlag.None,
                MapTestDataBuilder.CreateGround(new Location(100, 100, 7)), Array.Empty<IItem>(), null),
            new DynamicTile(new Coordinate(101, 100, 7), TileFlag.None,
                MapTestDataBuilder.CreateGround(new Location(101, 100, 7)), Array.Empty<IItem>(), new IItem[] { item }),
            destinationTile
        };

        var map = MapTestDataBuilder.Build(tiles);

        var sut = MonsterTestDataBuilder.Build(speed: 6000, map: map);
        sut.SetNewLocation(new Location(100, 100, 7));

        sut.Metadata.Flags.Add(CreatureFlagAttribute.CanPushItems, 1);

        var gameServer = GameServerTestBuilder.Build(map);
        var cancellationToken = ServerTestHelper.StartThreads(gameServer);

        sut.OnStartedWalking += new CreatureStartedWalkingEventHandler(gameServer).Execute;

        gameServer.Open();
        map.PlaceCreature(sut);

        //act
        sut.WalkTo(new Location(103, 100, 7));

        Task.Delay(2_000, cancellationToken).Wait(cancellationToken);

        //assert
        sut.Tile.Should().Be(destinationTile);
    }

    [Fact]
    public void Monster_without_can_push_items_flag_do_not_walk()
    {
        //arrange

        // --------------------------------------------------------------------------
        // |  Tile 1 (Monster is here) |  Tile 2 (object is here)  |  Tile 3 (Goal) |
        // --------------------------------------------------------------------------

        var itemType = new ItemType
        {
            Flags = { ItemFlag.BlockPathFind }
        };
        var item = new Item(itemType, new Location(101, 100, 7));

        var sourceTile = new DynamicTile(new Coordinate(100, 100, 7), TileFlag.None,
            MapTestDataBuilder.CreateGround(new Location(100, 100, 7)), Array.Empty<IItem>(), null);

        var tiles = new ITile[]
        {
            sourceTile,
            new DynamicTile(new Coordinate(101, 100, 7), TileFlag.None,
                MapTestDataBuilder.CreateGround(new Location(101, 100, 7)), Array.Empty<IItem>(), new IItem[] { item }),
            new DynamicTile(new Coordinate(102, 100, 7), TileFlag.None,
                MapTestDataBuilder.CreateGround(new Location(102, 100, 7)), Array.Empty<IItem>(), null)
        };

        var map = MapTestDataBuilder.Build(tiles);

        var sut = MonsterTestDataBuilder.Build(speed: 500, map: map);
        sut.SetNewLocation(new Location(100, 100, 7));

        sut.Metadata.Flags.Add(CreatureFlagAttribute.CanPushItems, 0);

        var gameServer = GameServerTestBuilder.Build(map);
        var cancellationToken = ServerTestHelper.StartThreads(gameServer);
        sut.OnStartedWalking += new CreatureStartedWalkingEventHandler(gameServer).Execute;

        gameServer.Open();

        map.PlaceCreature(sut);

        //act
        sut.WalkTo(new Location(104, 100, 7));

        Task.Delay(1_000, cancellationToken).Wait(cancellationToken);

        //assert
        sut.Tile.Should().Be(sourceTile);
    }
}