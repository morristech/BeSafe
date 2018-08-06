using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ExceptionManager
{
    public static class ExceptionHelper
    {
        private static readonly string ApplicationName = @"BeSafe";

        public static void Log(
            this Exception ex,
            ExceptionType type = ExceptionType.Unknown,
            string description = "",
            [CallerFilePath] string callerFilePath = "",
            [CallerMemberName] string callerMethodName = "",
            [CallerLineNumber] int callerLineNumber = 0)
        {
            string logMessage = $"FilePath : {callerFilePath} - MethodName : {callerMethodName} - LineNo : {callerLineNumber}" +
                                $"{Environment.NewLine}Exception :   {ex.Message}" +
                                $"{Environment.NewLine}Description : {description}";
            EventLog.WriteEntry(ApplicationName, logMessage, EventLogEntryType.Error, (int)type);
        }
    }
}