﻿using System;
using System.Text;
using Game.Combat.Spells;
using Game.Common;
using Game.Common.Contracts.Creatures;
using Game.Items;
using Server.Common.Contracts;
using Server.Configurations;
using Server.Helpers;

namespace Extensions.Spells.Commands;

public class SpyPlayerCommand : CommandSpell
{
    public override bool OnCast(ICombatActor actor, string words, out InvalidOperation error)
    {
        error = InvalidOperation.NotPossible;

        if (Params.Length == 0)
            return false;

        var ctx = IoC.GetInstance<IGameCreatureManager>();

        if (!ctx.TryGetPlayer(Params[0].ToString(), out var player))
            return false;

        var stringBuilder = new StringBuilder(1000);
        
        stringBuilder.AppendLine($"*** Name: {player.Name} *****");
        
        foreach (var inventoryDressingItem in player.Inventory.DressingItems)
        {
            stringBuilder.AppendLine($"ClientId: {inventoryDressingItem.Metadata.ClientId}-{inventoryDressingItem.FullName}");
        }

        var item = new ItemType();
        item.SetClientId(2821);
        
        var window = new ListCommandsCommand.TextWindow(item, player.Location, stringBuilder.ToString());
        var serverConfiguration = IoC.GetInstance<ServerConfiguration>();
       
        window.WrittenBy = $"{serverConfiguration.ServerName} - SERVER";
        window.WrittenOn = DateTime.Now;
        
        player.Read(window);
        
        return true;
    }
}