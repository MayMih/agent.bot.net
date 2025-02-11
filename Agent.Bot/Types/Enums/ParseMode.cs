﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Agent.Bot.Types.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ParseMode
    {
        Default = 0,
        HTML,
        MarkdownV2
    }
}
