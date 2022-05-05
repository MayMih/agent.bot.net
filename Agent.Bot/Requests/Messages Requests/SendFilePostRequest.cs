using Agent.Bot.Requests.Abstractions;
using Agent.Bot.Types;
using Agent.Bot.Types.InputFiles;
using Agent.Bot.Types.ReplyMarkups;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Specialized;
using System.Net.Http;

namespace Agent.Bot.Requests
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class SendFilePostRequest : FileRequestBase<MessagesResponse>,
                                       INotifiableMessage,
                                       IReplyMessage,
                                       IReplyMarkupMessage<IReplyMarkup>
    {
        public SendFilePostRequest(ChatId chatId, InputOnlineFile document)
            : base("/messages/sendFile", HttpMethod.Post)
        {
            ChatId = chatId;
            Document = document;
        }

        public override NameValueCollection BuildParameters()
        {
            var result = new NameValueCollection
            {
                { "chatId", ChatId },
            };

            if (!string.IsNullOrWhiteSpace(Caption))
            {
                result.Add("caption", Caption);
            }

            if (ReplyMarkup != null)
            {
                string markup = ReplyMarkup.ToJson();
                result.Add("inlineKeyboardMarkup", markup);
            }

            return result;
        }
    }
}
