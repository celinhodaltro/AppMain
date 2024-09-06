﻿using Game.Common;
using Game.Common.Contracts.Creatures;
using Game.Common.Creatures;
using Game.Common.Item;

namespace Extensions.Spells.Attack;

public class EnergyBeam : WaveSpell
{
    public override DamageType DamageType => DamageType.Energy;
    public override EffectT DamageEffect => EffectT.BubbleBlue;
    protected override string AreaName => "AREA_BEAM5";

    public override MinMax CalculateDamage(ICombatActor actor)
    {
        return new MinMax(5, 100);
    }
}