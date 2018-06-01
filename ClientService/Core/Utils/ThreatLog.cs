using System;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using BeSafe.Properties;
using ExceptionManager;
using PluginSDK;

namespace BeSafe.Core.Utils
{
    internal static class ThreatLog
    {
        public static bool Log(PluginResult log)
        {
            try
            {
                using (var serializedLog = new MemoryStream())
                {
                    BinaryFormatter bformatter = new BinaryFormatter();
                    bformatter.Serialize(serializedLog, log);

                    EventLog.WriteEntry(Resources.ApplicationName, log.PluginInfo.Name, EventLogEntryType.Warning, 2, 0, serializedLog.ToArray());
                }

                return true;
            }
            catch (Exception ex)
            {
                ex.Log();
                return false;
            }
        }
    }
}