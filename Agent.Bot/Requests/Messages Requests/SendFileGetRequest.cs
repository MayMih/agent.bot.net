using Agent.Bot.Exceptions;
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
    public class SendFileGetRequest : FileRequestBase<MessagesResponse>,
                                       INotifiableMessage,
                                       IReplyMessage,
                                       IReplyMarkupMessage<IReplyMarkup>
    {
        public SendFileGetRequest(ChatId chatId, InputOnlineFile document)
            : base("/messages/sendFile", HttpMethod.Get)
        {
            ChatId = chatId;
            Document = document;
        }

        public override NameValueCollection BuildParameters()
        {
            if (Document == null || string.IsNullOrWhiteSpace(Document.FileId))
            {
                throw new FileIdNotFoundException();
            }

            var result = new NameValueCollection
            {
                { "chatId", ChatId },
                { "fileId", Document.FileId }
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
