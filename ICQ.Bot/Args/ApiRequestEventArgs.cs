﻿using System;
using System.Net.Http;

namespace ICQ.Bot.Args
{
    public class ApiRequestEventArgs : EventArgs
    {
        public string MethodName { get; internal set; }
        public HttpContent HttpContent { get; internal set; }
    }
}