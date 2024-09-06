﻿using System.Collections.Generic;
using Game.Common.Contracts;
using Game.Common.Contracts.Items;
using Game.Common.Location.Structs;
using Game.Items.Items.Containers;
using Game.Items.Items.Containers.Container;

namespace Game.Items.Factories;

public class ContainerFactory : IFactory
{
    public event CreateItem OnItemCreated;


    public IItem Create(IItemType itemType, Location location, IEnumerable<IItem> children)
    {
        if (Depot.IsApplicable(itemType)) return new Depot(itemType, location, children);
        if (Container.IsApplicable(itemType)) return new Container(itemType, location, children);

        return null;
    }
}