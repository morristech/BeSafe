using System;
using System.IO;
using System.Linq;
using System.Reflection;
using ClientUI.Properties;
using System.Collections.Generic;
using ExceptionManager;
using PluginSDK;

namespace ClientUI.Core.Utils
{
    public class PluginUtils
    {
        public List<IBeSafePlugin> GetPluginsInfo(string pluginDirectory)
        {
            var pluginsInfo = new List<IBeSafePlugin>();

            if (!Directory.Exists(pluginDirectory))
                return pluginsInfo;

            // Search for plugin files in plugin directory & get information of plugins
            foreach (var pluginFile in Directory.GetFiles(pluginDirectory, Resources.PluginSearchPattern))
            {
                try
                {
                    var assemblyInfo = Assembly.LoadFile(pluginFile);
                    var pluginAssembly = CreateBeSafePluginInstance(assemblyInfo);
                    if (pluginAssembly != null)
                        pluginsInfo.Add(pluginAssembly);
                }
                catch (Exception ex)
                {
                    ex.Log();
                }
            }

            return pluginsInfo;
        }

        public IBeSafePlugin CreateBeSafePluginInstance(Assembly assembly)
        {
            if (assembly == null)
                throw new ArgumentNullException(nameof(assembly));

            var firstOrDefault = assembly.DefinedTypes.FirstOrDefault(f => typeof(IBeSafePlugin).IsAssignableFrom(f));
            if (!string.IsNullOrEmpty(firstOrDefault?.FullName))
            {
                Type assemblyType =
                    assembly.GetType(firstOrDefault.FullName);
                if (assemblyType != null)
                {
                    var argTypes = new Type[] { };
                    ConstructorInfo constructorInfo = assemblyType.GetConstructor(argTypes);
                    return (IBeSafePlugin)constructorInfo?.Invoke(null);
                }
            }

            return null;
        }
    }
}