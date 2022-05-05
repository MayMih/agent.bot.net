﻿namespace Agent.Bot.Exceptions
{
    public class InvalidStickerEmojisException : InvalidParameterException
    {
        public InvalidStickerEmojisException(string message)
            : base("emojis", message)
        {
        }
    }
}