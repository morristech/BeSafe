using System;
using System.Collections.Generic;
using PluginSDK;
using PluginSDK.PluginInterfaces;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    public class ProcessPluginRegulator
    {
        #region Singleton
        private static ProcessPluginRegulator SingletonInstance;
        public static ProcessPluginRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new ProcessPluginRegulator()));
        #endregion

        public PluginResult Scan(Dictionary<string, IBeSafeProcessPlugin> plugins, dynamic scanObject, bool canFight)
        {
            throw new NotImplementedException();
        }
    }
}