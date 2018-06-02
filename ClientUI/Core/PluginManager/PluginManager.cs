using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using ExceptionManager;
using PluginSDK;
using ClientUI.Properties;
using Common.Utils;
using PluginSDK.PluginInterfaces;

namespace ClientUI.Core.PluginManager
{
    public class PluginManager
    {
        public static void LoadPluginsInfoToListBox(ListBox listbox)
        {
            listbox.Items.Clear();

            List<IBeSafeFilePlugin> filePlugins = new PluginUtils().GetPluginsInfo<IBeSafeFilePlugin>(PathUtils.PluginsPath);
            foreach (IBeSafeFilePlugin plugin in filePlugins)
                listbox.Items.Add(plugin.GetPluginInfo());

            List<IBeSafeRegistryPlugin> registryPlugins = new PluginUtils().GetPluginsInfo<IBeSafeRegistryPlugin>(PathUtils.PluginsPath);
            foreach (IBeSafeRegistryPlugin plugin in registryPlugins)
                listbox.Items.Add(plugin.GetPluginInfo());

            List<IBeSafeProcessPlugin> processPlugins = new PluginUtils().GetPluginsInfo<IBeSafeProcessPlugin>(PathUtils.PluginsPath);
            foreach (IBeSafeProcessPlugin plugin in processPlugins)
                listbox.Items.Add(plugin.GetPluginInfo());

            List<IBeSafeModulePlugin> modulePlugins = new PluginUtils().GetPluginsInfo<IBeSafeModulePlugin>(PathUtils.PluginsPath);
            foreach (IBeSafeModulePlugin plugin in modulePlugins)
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