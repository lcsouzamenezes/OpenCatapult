﻿// Copyright (c) Polyrific, Inc 2018. All rights reserved.

using System;
using Microsoft.Extensions.Logging;

namespace Polyrific.Catapult.Plugins.Core
{
    public class TaskLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            var message = formatter?.Invoke(state, exception);

            Console.WriteLine($"[LOG][{Enum.GetName(typeof(LogLevel), logLevel)}]{message}");
        }
        
    }
}