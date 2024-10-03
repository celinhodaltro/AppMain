﻿using Game.Chats;
using Game.Chats.Rules;
using Server.Entities.Common.Chats;

namespace Extensions.Chat;

public class LootChannel : PersonalChatChannel
{
    public LootChannel(ushort id, string name) : base(id, name)
    {
    }

    public override string Name => "Loot";

    public override bool Opened
    {
        get => false;
        init => base.Opened = value;
    }

    public override SpeechType ChatColor
    {
        get => SpeechType.ChannelWhiteText;
        init => base.ChatColor = SpeechType.ChannelWhiteText;
    }

    public override ChannelRule WriteRule
    {
        get => new()
        {
            AllowedVocations = new[] { byte.MaxValue }
        };
        init => base.WriteRule = value;
    }
}