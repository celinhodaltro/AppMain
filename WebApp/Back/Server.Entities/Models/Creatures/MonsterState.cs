﻿namespace Server.Entities.Models.Creatures;

/// <summary>
///     A state machine no control monster
/// </summary>
public enum MonsterState
{
    Sleeping,
    InCombat,
    Escaping,
    LookingForEnemy,
    Awake
}