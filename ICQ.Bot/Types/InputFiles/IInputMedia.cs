using Agent.Bot.Types.Enums;

namespace Agent.Bot.Types
{
    public interface IInputMedia
    {
        string Type { get; }
        InputMedia Media { get; }
        string Caption { get; }
        ParseMode ParseMode { get; }
    }
}
