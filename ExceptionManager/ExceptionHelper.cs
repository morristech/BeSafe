using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace ExceptionManager
{
    public static class ExceptionHelper
    {
        private static readonly string ApplicationName = @"BeSafe";
        private static readonly string LogPathName = "Logs";

        public static List<ExceptionLog> Logs { get; private set; }

        public static bool LogToFile(
            this Exception exception,
            ExceptionType type = ExceptionType.Unknown,
            string description = "",
            [CallerFilePath] string callerFilePath = "",
            [CallerMemberName] string callerMethodName = "",
            [CallerLineNumber] int callerLineNumber = 0)
        {
            try
            {           
                if (Logs == null)
                    Load();

                ExceptionLog log = new ExceptionLog
                {
                    Type = type,
                    Date = DateTime.Now,
                    FilePath = callerFilePath,
                    MethodName = callerMethodName,
                    LineNumber = callerLineNumber,
                    Description = description,
                    Exception = exception
                };

                Logs?.Add(log);
                Save();

                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Load config file and deserialize it
        /// </summary>
        /// <returns>Determine load process success or not</returns>
        private static bool Load()
        {
            try
            {
                string todayLogFilePath = TodayLogFilePath();

                if (File.Exists(todayLogFilePath))
                {
                    using (var tempStream = new MemoryStream(File.ReadAllBytes(todayLogFilePath)))
                    {
                        BinaryFormatter bformatter = new BinaryFormatter();
                        List<ExceptionLog> tempConfig = (List<ExceptionLog>) bformatter.Deserialize(tempStream);

                        Logs = tempConfig;
                    }
                }
                else
                    Logs = new List<ExceptionLog>();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Serialize current config and save to config file
        /// </summary>
        /// <returns>Determine save config process success or not</returns>
        public static bool Save(string logFilePath = null)
        {
            try
            {
                // If user not specify log path, use default daily log file path
                if (string.IsNullOrWhiteSpace(logFilePath))
                    logFilePath = TodayLogFilePath();

                using (var tempStream = new MemoryStream())
                {
                    BinaryFormatter bformatter = new BinaryFormatter();
                    bformatter.Serialize(tempStream, Logs);
                    File.WriteAllBytes(logFilePath, tempStream.ToArray());
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static string TodayLogFilePath()
        {
            string todayLogFileName = $"{DateTime.Now.ToShortDateString().Replace("/", "_")}.log";
            return Path.Combine(LogPath(), todayLogFileName);
        }

        private static string LogPath()
        {
            string dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ApplicationName);
            string logPath = Path.Combine(dataPath, LogPathName);
            if (!Directory.Exists(logPath))
                Directory.CreateDirectory(logPath);

            return logPath;
        }
    }
}