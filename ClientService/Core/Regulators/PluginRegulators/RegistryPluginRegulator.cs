using System;
using System.Collections.Generic;
using PluginSDK;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    public class RegistryPluginRegulator : IPluginRegulator
    {
        #region Singleton
        private static RegistryPluginRegulator SingletonInstance;
        public static RegistryPluginRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new RegistryPluginRegulator()));
        #endregion

        public PluginResult Scan(List<IBeSafePlugin> plugins, dynamic scanObject, bool canFight)
        {
            throw new NotImplementedException();
        }
    }
}