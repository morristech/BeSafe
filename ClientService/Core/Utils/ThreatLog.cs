using System;
using System.Collections.Generic;
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

    }
}