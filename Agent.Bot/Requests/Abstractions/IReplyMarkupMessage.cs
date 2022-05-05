using Agent.Bot.Types.ReplyMarkups;

namespace Agent.Bot.Requests.Abstractions
{
    public interface IReplyMarkupMessage<TMarkup>
        where TMarkup : IReplyMarkup
    {
        TMarkup ReplyMarkup { get; set; }
    }
}
