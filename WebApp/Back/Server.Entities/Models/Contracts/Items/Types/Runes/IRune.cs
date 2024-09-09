﻿using System.Text;
using Server.Entities.Models.Contracts.Creatures;
using Server.Entities.Models.Creatures;
using Server.Entities.Models.Creatures.Structs;

namespace Server.Entities.Models.Contracts.Items.Types.Runes;

public interface IRune : IUsableRequirement, IFormula
{
    public CooldownTime Cooldown { get; }

    public string ValidationError
    {
        get
        {
            var text = new StringBuilder();
            text.Append("Only ");
            text.Append($" of magic level {MinLevel} or above may use or consume this item");
            return text.ToString();
        }
    }

    public bool CanBeUsed(IPlayer player)
    {
        var vocations = Vocations;
        if (vocations?.Length > 0)
            if (!vocations.Contains(player.Vocation.VocationType))
                return false;
        if (MinLevel <= 0) return true;
        return (player?.GetSkillLevel(SkillType.Magic) ?? 0) >= MinLevel;
    }
}