﻿using System.Collections.Generic;
using Game.Common.Contracts.Creatures;
using Game.Common.Creatures;

namespace Game.Creatures.Models;

public class CreatureType : ICreatureType
{
    public CreatureType(string name, string description, uint maxHealth, ushort speed,
        IDictionary<LookType, ushort> look)
    {
        Name = name;
        Description = description;
        MaxHealth = maxHealth;
        Speed = speed;
        Look = look;
    }

    public string Description { get; }
    public string Name { get; }
    public uint MaxHealth { get; }
    public ushort Speed { get; set; }
    public IDictionary<LookType, ushort> Look { get; }
}