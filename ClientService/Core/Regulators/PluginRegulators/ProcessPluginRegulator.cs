using System;
using System.Collections.Generic;
using PluginSDK;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    public class ProcessPluginRegulator : IPluginRegulator
    {
        #region Singleton
        private static ProcessPluginRegulator SingletonInstance;
        public static ProcessPluginRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new ProcessPluginRegulator()));
        #endregion

        public PluginResult Scan(List<IBeSafePlugin> plugins, dynamic scanObject, bool canFight)
        {
            throw new NotImplementedException();
        }
    }
}