﻿using Server.Entities.Models.Contracts.Items;

namespace Server.Entities.Models.Contracts.Services;

/// <summary>
///     Service for removing items from the game world.
/// </summary>
public interface IItemRemoveService
{
    /// <summary>
    ///     Removes an item from the game world.
    ///     This method doesn't mark the item as deleted
    /// </summary>
    /// <param name="item">The item to remove.</param>
    void Remove(IItem item);
}