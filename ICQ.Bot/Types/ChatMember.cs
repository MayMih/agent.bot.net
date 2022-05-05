using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Agent.Bot.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ChatMember
    {
        [JsonProperty(Required = Required.Always)]
        public long UserId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Creator { get; set; }
    }
}
