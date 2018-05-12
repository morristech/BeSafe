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

            _plugins = pluginUtils.GetPluginsInfo(_config.PluginsPath);
        }

        public PluginResult IsFileSafeToExecute(string filePath)
        {
            PluginResult scanResult = new PluginResult();

            foreach (IBeSafePlugin plugin in _plugins)
            {
                string fileExt = Path.GetExtension(filePath);
                List<string> pluginSupportedFileTypes = plugin.GetPluginInfo().SupportedFileTypes;

                if (pluginSupportedFileTypes.Contains(fileExt))
                {
                    scanResult = plugin.ScanFile(filePath);

                    if (scanResult.Threat == true)
                        break;
                }
            }

            return scanResult;
        }

        public bool AutoQuarantine
        {
            get
            {
                return _config.ComponentsState.AutoQuarantine;
            }
        }
    }
}