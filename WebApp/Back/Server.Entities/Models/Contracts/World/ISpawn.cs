﻿using Server.Entities.Models.Location;
using Server.Entities.Models.Location.Structs;

namespace Server.Entities.Models.Contracts.World;

public interface ISpawn
{
    Location.Structs.Location Location { get; set; }
    ICreature[] Monsters { get; set; }
    ICreature[] Npcs { get; set; }

    public interface ICreature
    {
        string Name { get; set; }
        ISpawnPoint Spawn { get; set; }
    }
}

public interface ISpawnPoint
{
    Location.Structs.Location Location { get; }
    ushort SpawnTime { get; }
    Direction Direction { get; set; }
}