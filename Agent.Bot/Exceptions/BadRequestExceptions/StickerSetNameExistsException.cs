﻿namespace Agent.Bot.Exceptions
{
    public class StickerSetNameExistsException : BadRequestException
    {
        public StickerSetNameExistsException(string message)
            : base(message)
        {
        }
    }
}