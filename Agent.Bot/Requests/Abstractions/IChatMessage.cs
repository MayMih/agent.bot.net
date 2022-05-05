using Agent.Bot.Types;

namespace Agent.Bot.Requests.Abstractions
{
    public interface IChatMessage
    {
        ChatId ChatId { get; }
    }
}
