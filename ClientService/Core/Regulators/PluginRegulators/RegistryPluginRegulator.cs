using System.Collections.Generic;
using System.Diagnostics;
using PluginSDK;
using PluginSDK.PluginInterfaces;
using SharedTypes.Watchers.RegistryWatcherTypes;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    public class RegistryPluginRegulator
    {
        #region Singleton
        private static RegistryPluginRegulator SingletonInstance;
        public static RegistryPluginRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new RegistryPluginRegulator()));
        #endregion

        public PluginResult Scan(List<IBeSafeRegistryPlugin> plugins, dynamic scanObject, bool canFight)
        {
            ChangedValueInfo regitryValueInfo = (ChangedValueInfo)scanObject;
            if (regitryValueInfo == null)
                return null;

            PluginResult scanResult = new PluginResult();

            foreach (IBeSafeRegistryPlugin plugin in plugins)
            {
                scanResult = plugin.Scan(regitryValueInfo, canFight);
                Debug.WriteLine(scanResult.RiskRate);
                if (scanResult.RiskRate != ThreatRiskRates.NoRisk)
                    break;
            }

            return scanResult;
        }
    }
}