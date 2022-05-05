using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Agent.Bot.Types.Enums;

namespace Agent.Bot.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public abstract class InputMediaBase : IInputMedia
    {
        [JsonProperty(Required = Required.Always)]
        public string Type { get; protected set; }

        [JsonProperty(Required = Required.Always)]
        public InputMedia Media { get; set; } // ToDo Should be get-only. Media is set in ctors

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ParseMode ParseMode { get; set; }
    }
}
