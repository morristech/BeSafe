using System;
using System.Collections.Generic;
using PluginSDK;
using PluginSDK.PluginInterfaces;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    public class ModulePluginRegulator
    {
        #region Singleton
        private static ModulePluginRegulator SingletonInstance;
        public static ModulePluginRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new ModulePluginRegulator()));
        #endregion

        public PluginResult Scan(List<IBeSafeModulePlugin> plugins, dynamic scanObject, bool canFight)
        {
            throw new NotImplementedException();
        }
    }
}