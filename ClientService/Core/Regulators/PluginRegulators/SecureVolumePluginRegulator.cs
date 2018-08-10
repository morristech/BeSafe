using System.IO;
using System.Collections.Generic;
using PluginSDK;
using PluginSDK.PluginInterfaces;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    public class SecureVolumePluginRegulator
    {
        #region Singleton
        private static SecureVolumePluginRegulator SingletonInstance;
        public static SecureVolumePluginRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new SecureVolumePluginRegulator()));
        #endregion
       

        public PluginResult Scan(Dictionary<string, IBeSafeFilePlugin> plugins, dynamic scanObject, bool canFight)
        {
            string filePath = (string)scanObject;
            if (string.IsNullOrEmpty(filePath))
                return null;

            PluginResult scanResult = new PluginResult();

            foreach (KeyValuePair<string, IBeSafeFilePlugin> plugin in plugins)
            {
                string fileExt = Path.GetExtension(filePath);
                string pluginSupportedFileTypes = plugin.Value.GetPluginInfo().Description;

                if (pluginSupportedFileTypes.Contains(fileExt))
                {
                    scanResult = plugin.Value.Scan(filePath, canFight);

                    if (scanResult.RiskRate != ThreatRiskRates.NoRisk)
                        break;
                }
            }

            return scanResult;
        }
    }
}