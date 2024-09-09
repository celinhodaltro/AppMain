using System.Collections.Generic;
using Game.Common.Location;
using Game.Common.Location.Structs;
using Server.Entities.Models;
using Server.Entities.Models.Combat.Structs;
using Server.Entities.Models.Contracts.Creatures;
using Server.Entities.Models.Contracts.Items;
using Server.Entities.Models.Contracts.Items.Types;
using Server.Entities.Models.Contracts.World.Tiles;

namespace Server.Entities.Models.Contracts.World;

public delegate void PlaceCreatureOnMap(IWalkableCreature creature, ICylinder cylinder);

public delegate void RemoveThingFromTile(IThing thing, ICylinder cylinder);

public delegate void MoveCreatureOnFloor(IWalkableCreature creature, ICylinder cylinder);

public delegate void AddThingToTile(IThing thing, ICylinder cylinder);

public delegate void UpdateThingOnTile(IThing thing, ICylinder cylinder);

public delegate void FailedMoveThing(IThing thing, InvalidOperation error);

public interface IMap
{
    ITile this[Location location] { get; }
    ITile this[ushort x, ushort y, byte z] { get; }

    event PlaceCreatureOnMap OnCreatureAddedOnMap;
    event RemoveThingFromTile OnThingRemovedFromTile;
    event MoveCreatureOnFloor OnCreatureMoved;
    event FailedMoveThing OnThingMovedFailed;
    event AddThingToTile OnThingAddedToTile;
    event UpdateThingOnTile OnThingUpdatedOnTile;

    IList<byte> GetDescription(IThing thing, ushort fromX, ushort fromY, byte currentZ,
        byte windowSizeX = 18, byte windowSizeY = 14);

    bool ArePlayersAround(Location location);
    void PlaceCreature(ICreature creature);
    ITile GetNextTile(Location fromLocation, Direction direction);

    IList<byte> GetFloorDescription(IThing thing, ushort fromX, ushort fromY, byte currentZ, byte width,
        byte height, int verticalOffset, ref int skip);

    IEnumerable<ICreature> GetPlayersAtPositionZone(Location location);

    bool IsInRange(Location start, Location current, Location target,
        FindPathParams fpp);

    HashSet<ICreature> GetCreaturesAtPositionZone(Location location,
        Location toLocation);

    void PropagateAttack(ICombatActor actor, CombatDamage damage, AffectedLocation[] area);
    void MoveCreature(IWalkableCreature creature);
    void CreateBloodPool(ILiquid liquid, IDynamicTile tile);
    ITile GetTileDestination(ITile tile);
    bool TryMoveCreature(ICreature creature, Location toLocation);
    void RemoveCreature(ICreature creature);

    void SwapCreatureBetweenSectors(ICreature creature, Location fromLocation,
        Location toLocation);

    HashSet<ICreature> GetSpectators(Location fromLocation, Location toLocation,
        bool onlyPlayers = false);

    HashSet<ICreature> GetSpectators(Location fromLocation, bool onlyPlayers = false);
    IEnumerable<ICreature> GetCreaturesAtPositionZone(Location location, bool onlyPlayers = false);
    bool CanGoToDirection(ICreature creature, Direction direction, ITileEnterRule rule);
    ITile GetTile(Location location);
    ITile GetFinalTile(ITile toTile);
    void ReplaceTile(ITile newTile);
}