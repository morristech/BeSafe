using System.Collections.Generic;
using System.Diagnostics;
using PluginSDK;
using SharedTypes.Watchers.RegistryWatcherTypes;

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
            ChangedValueInfo regitryValueInfo = (ChangedValueInfo)scanObject;
            if (regitryValueInfo == null)
                return null;

            PluginResult scanResult = new PluginResult();

            foreach (IBeSafePlugin plugin in plugins)
            {
                scanResult = plugin.ScanRegistry(regitryValueInfo, canFight);
                Debug.WriteLine(scanResult.RiskRate);
                if (scanResult.RiskRate != ThreatRiskRates.NoRisk)
                    break;
            }

            return scanResult;
        }
    }
}