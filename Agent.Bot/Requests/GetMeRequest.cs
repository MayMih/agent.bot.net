using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Agent.Bot.Types;
using System.Net.Http;

namespace Agent.Bot.Requests
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class GetMeRequest : ParameterlessRequest<User>
    {
        public GetMeRequest()
            : base("/self/get", HttpMethod.Get)
        { }
    }
}
