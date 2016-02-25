﻿using System;
using Foundatio.Utility;

namespace Foundatio.Logging {
    public class NullLogger : ILogger {
        public static readonly ILogger Instance = new NullLogger();

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter) { }

        public bool IsEnabled(LogLevel logLevel) {
            return false;
        }

        public IDisposable BeginScope<TState, TScope>(Func<TState, TScope> scopeFactory, TState state) {
            return new EmptyDisposable();
        }
    }
}