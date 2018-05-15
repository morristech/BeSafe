using System.IO;
using System.Collections.Generic;
using Common.Utils;
using PluginSDK;
using ConfigManager;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    public class PluginRegulator
    {
        private readonly PluginUtils pluginUtils = new PluginUtils();
        private readonly BeSafeConfig _config;

        private List<IBeSafePlugin> _plugins;

        public PluginRegulator(BeSafeConfig config)
        {
            _config = config;
        }

        public PluginResult IsFileSafeToExecute(string filePath)
        {
            _plugins = pluginUtils.GetPluginsInfo(_config.PluginsPath);

            PluginResult scanResult = new PluginResult();

            foreach (IBeSafePlugin plugin in _plugins)
            {
                string fileExt = Path.GetExtension(filePath);
                string pluginSupportedFileTypes = plugin.GetPluginInfo().Description;

                if (pluginSupportedFileTypes.Contains(fileExt))
                {
                    scanResult = plugin.ScanFile(filePath, _config.ComponentsState.FightWithThreats);

                    if (scanResult.Threat == true)
                        break;
                }
            }

            return scanResult;
        }

        public bool AutoQuarantineThreatFile
        {
            get
            {
                return _config.ComponentsState.FightWithThreats;
            }
        }
    }
}