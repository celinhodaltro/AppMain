﻿using Game.Common.Item;

namespace Game.Common.Contracts.Items.Types;

public interface ILiquid : IItem
{
    bool IsLiquidPool { get; }

    bool IsLiquidSource { get; }

    bool IsLiquidContainer { get; }
    LiquidColor LiquidColor { get; }
}