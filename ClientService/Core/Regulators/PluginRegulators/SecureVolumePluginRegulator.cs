using System.IO;
using System.Collections.Generic;
using PluginSDK;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    public class SecureVolumePluginRegulator : IPluginRegulator
    {
        #region Singleton
        private static SecureVolumePluginRegulator SingletonInstance;
        public static SecureVolumePluginRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new SecureVolumePluginRegulator()));
        #endregion
       

        public PluginResult Scan(List<IBeSafePlugin> plugins, dynamic scanObject, bool canFight)
        {
            string filePath = (string)scanObject;
            if (string.IsNullOrEmpty(filePath))
                return null;

            PluginResult scanResult = new PluginResult();

            foreach (IBeSafePlugin plugin in plugins)
            {
                string fileExt = Path.GetExtension(filePath);
                string pluginSupportedFileTypes = plugin.GetPluginInfo().Description;

                if (pluginSupportedFileTypes.Contains(fileExt))
                {
                    scanResult = plugin.ScanFile(filePath, canFight);

                    if (scanResult.RiskRate != ThreatRiskRates.NoRisk)
                        break;
                }
            }

            return scanResult;
        }
    }
}