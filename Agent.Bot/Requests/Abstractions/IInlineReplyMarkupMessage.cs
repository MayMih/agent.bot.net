using Agent.Bot.Types.ReplyMarkups;

namespace Agent.Bot.Requests.Abstractions
{
    public interface IInlineReplyMarkupMessage : IReplyMarkupMessage<InlineKeyboardMarkup>
    {
        new InlineKeyboardMarkup ReplyMarkup { get; set; }
    }
}
