﻿using Server.Entities.Models.Location.Structs;
using Server.Entities.Models.Contracts.Creatures;

namespace Server.Entities.Models.Contracts.Items.Types;

public interface IMagicField
{
    Location.Structs.Location Location { get; }
    IItemType Metadata { get; }

    void CauseDamage(ICreature toCreature);
}