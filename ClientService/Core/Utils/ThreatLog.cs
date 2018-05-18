using System;
using System.Collections.Concurrent;
using PluginSDK;
using ExceptionManager;

namespace BeSafe.Core.Utils
{
    internal class ThreatLog
    {
        #region Singleton
        private static ThreatLog SingletonInstance;
        public static ThreatLog Instance() => (SingletonInstance ?? (SingletonInstance = new ThreatLog()));
        #endregion


        private ConcurrentQueue<PluginResult> _logs;

        public bool Add(PluginResult log)
        {
            try
            {
                _logs.Enqueue(log);

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