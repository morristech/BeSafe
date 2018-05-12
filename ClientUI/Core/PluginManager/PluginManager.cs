using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using ClientUI.Core.Utils;
using ExceptionManager;
using PluginSDK;
using ClientUI.Properties;

namespace ClientUI.Core.PluginManager
{
    public class PluginManager
    {
        public static void LoadPluginsInfoToListBox(ListBox listbox)
        {
            listbox.Items.Clear();

            List<IBeSafePlugin> plugins = new PluginUtils().GetPluginsInfo(PathUtils.PluginsPath);
            foreach (IBeSafePlugin plugin in plugins)
                listbox.Items.Add(plugin.GetPluginInfo());
        }

        public static LoadPluginResult LoadPlugin(string pluginPath)
        {
            if (string.IsNullOrEmpty(pluginPath))
                throw new ArgumentNullException(nameof(pluginPath));

            try
            {
                // Gnerate random name for plugin and build full plugin path using it
                string pluginsDirectory = PathUtils.PluginsPath;
                string pluginName = Guid.NewGuid().ToString() + Resources.BeSafePluginFileFormat;
                string destinationpathOfPlugin = Path.Combine(pluginsDirectory, pluginName);

                // TODO Should check plugin already exists using plugin informations of plugins stored in "Plugins" directory and compare with current plugin
                //return LoadPluginResult.AlreadyExists;

                File.Copy(pluginPath, destinationpathOfPlugin);
            }
            catch(Exception ex)
            {
                ex.Log();
                return LoadPluginResult.Failed;
            }

            return LoadPluginResult.Success;
        }

        public static bool UnloadPlugin(PluginInfo pluginInfo)
        {
            // TODO Shoud load plugins in separate APPDomain, this let us unload the domain and all plugins
            throw new NotImplementedException();
        }
    }
}