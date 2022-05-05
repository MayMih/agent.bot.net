namespace Agent.Bot.Requests.Abstractions
{
    public interface INotifiableMessage
    {
        bool DisableNotification { get; set; }
    }
}
