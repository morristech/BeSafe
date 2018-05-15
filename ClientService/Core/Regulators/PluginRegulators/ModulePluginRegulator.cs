using System;
using System.Collections.Generic;
using PluginSDK;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    public class ModulePluginRegulator : IPluginRegulator
    {
        #region Singleton
        private static ModulePluginRegulator SingletonInstance;
        public static ModulePluginRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new ModulePluginRegulator()));
        #endregion

        public PluginResult Scan(List<IBeSafePlugin> plugins, dynamic scanObject, bool canFight)
        {
            throw new NotImplementedException();
        }
    }
}