using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Agent.Bot.Types.Enums
{
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum ChatType
    {
        Private,
        Group,
        Channel,
        Supergroup
    }
}
