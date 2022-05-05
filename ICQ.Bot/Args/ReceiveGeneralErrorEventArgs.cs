using System;

namespace Agent.Bot.Args
{
    public class ReceiveGeneralErrorEventArgs : EventArgs
    {
        public Exception Exception { get; }

        internal ReceiveGeneralErrorEventArgs(Exception exception)
        {
            Exception = exception;
        }

        public static implicit operator ReceiveGeneralErrorEventArgs(Exception e) => new ReceiveGeneralErrorEventArgs(e);
    }
}
