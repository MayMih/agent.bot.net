﻿namespace Agent.Bot.Exceptions
{
    public class UserNotFoundException : BadRequestException
    {
        public UserNotFoundException(string message)
            : base(message)
        {
        }
    }
}