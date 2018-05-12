using System.IO;
using System.Collections.Generic;
using Common.Utils;
using PluginSDK;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    public class PluginRegulator
    {
        private readonly PluginUtils pluginUtils = new PluginUtils();
        private readonly string _pluginsDirectoryPath;

        private List<IBeSafePlugin> _plugins;

        public PluginRegulator(string pluginsDirectoryPath)
        {
            _pluginsDirectoryPath = pluginsDirectoryPath;

            _plugins = pluginUtils.GetPluginsInfo(pluginsDirectoryPath);
        }

        public PluginResult IsFileSafeToExecute(string filePath)
        {
            PluginResult scanResult = new PluginResult();

            foreach(IBeSafePlugin plugin in _plugins)
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
    }
}