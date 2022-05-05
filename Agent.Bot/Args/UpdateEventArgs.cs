using System;
using Agent.Bot.Types;

namespace Agent.Bot.Args
{
    public class UpdateEventArgs : EventArgs
    {
        public Update Update { get; private set; }

        internal UpdateEventArgs(Update update)
        {
            Update = update;
        }
    }
}