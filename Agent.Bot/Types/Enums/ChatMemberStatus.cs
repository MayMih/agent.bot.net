﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Agent.Bot.Types.Enums
{
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum ChatMemberStatus
    {
        Creator,
        Administrator,
        Member,
        Left,
        Kicked,
        Restricted
    }
}
