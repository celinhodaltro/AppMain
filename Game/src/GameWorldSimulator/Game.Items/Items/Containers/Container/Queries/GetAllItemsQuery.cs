﻿using System.Collections.Generic;
using Game.Common.Contracts.Items;
using Game.Common.Contracts.Items.Types.Containers;

namespace Game.Items.Items.Containers.Container.Queries;

internal static class GetRecursiveItemsQuery
{
    public static List<IItem> Get(IContainer container)
    {
        var items = new List<IItem>();

        foreach (var item in container.Items)
        {
            if (item is not IContainer innerContainer)
            {
                items.Add(item);
                continue;
            }

            items.Add(innerContainer);
            items.AddRange(Get(innerContainer));
        }

        return items;
    }
}