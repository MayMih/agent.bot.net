namespace Agent.Bot.Exceptions
{
    public class InvalidUserIdException : InvalidParameterException
    {
        public InvalidUserIdException(string message)
            : base("userId", message)
        {
        }
    }
}