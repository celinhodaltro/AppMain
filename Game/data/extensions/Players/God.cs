﻿using System;
using System.Collections.Generic;
using Game.Common.Combat.Structs;
using Game.Common.Contracts.Creatures;
using Game.Common.Contracts.Items;
using Game.Common.Contracts.World;
using Game.Common.Contracts.World.Tiles;
using Game.Common.Creatures;
using Game.Common.Creatures.Players;
using Game.Common.Location.Structs;

namespace Extensions.Players;

public class God : Tutor
{
    public God(uint id, string characterName, IVocation vocation, Gender gender, bool online,
        IDictionary<SkillType, ISkill> skills, IOutfit outfit,
        ushort speed, Location location,
        IMapTool mapTool, ITown town) :
        base(id, characterName, vocation, gender, online, skills, outfit, speed, location, mapTool, town)
    {
        SetFlags(PlayerFlag.CanSeeInvisibility, PlayerFlag.SpecialVip);
    }

    public override bool CanSeeInvisible => FlagIsEnabled(PlayerFlag.CanSeeInvisibility);
    public override bool CannotLogout => false;
    public override bool CanBeSeen => false;
    public override bool CanSeeInspectionDetails => true;

    public override void GainExperience(long exp)
    {
    } //tutor do not gain experience

    public override void LoseExperience(long exp)
    {
        Console.WriteLine("god do not lose experience");
    }

    public override bool ReceiveAttack(IThing enemy, CombatDamage damage)
    {
        return false;
    }

    public override void OnDamage(IThing enemy, CombatDamage damage)
    {
    }

    public override void OnMoved(IDynamicTile fromTile, IDynamicTile toTile, ICylinderSpectator[] spectators)
    {
        Containers.CloseDistantContainers();
        base.OnMoved(fromTile, toTile, spectators);
    }

    public override void OnAppear(Location location, ICylinderSpectator[] spectators)
    {
    }

    public override void SetAsInFight()
    {
    }
}