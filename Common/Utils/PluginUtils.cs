using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using ExceptionManager;
using Common.Properties;

namespace Common.Utils
{
    public class PluginUtils
    {
        public Dictionary<string, T> GetPluginsInfo<T>(string pluginDirectory) where T : class
        {
            if (!Directory.Exists(pluginDirectory))
                return null;

            // Search for plugin files in plugin directory & get information of plugins
            var pluginsInfo = new Dictionary<string, T>();

            try
            {
                foreach (var pluginFile in Directory.GetFiles(pluginDirectory, Resources.PluginSearchPattern))
                {
                    var assemblyInfo = Assembly.LoadFile(pluginFile);
                    var pluginAssembly = CreateBeSafePluginInstance<T>(assemblyInfo);
                    if (pluginAssembly != null)
                        pluginsInfo.Add(pluginFile, pluginAssembly);
                }

            }
            catch (Exception ex)
            {
                ex.Log();
            }

            return pluginsInfo;
        }

        private T CreateBeSafePluginInstance<T>(Assembly assembly) where T : class
        {
            if (assembly == null)
                throw new ArgumentNullException(nameof(assembly));

            var firstOrDefault = assembly.DefinedTypes.FirstOrDefault(f => typeof(T).IsAssignableFrom(f));
            if (!string.IsNullOrEmpty(firstOrDefault?.FullName))
            {
                Type assemblyType =
                    assembly.GetType(firstOrDefault.FullName);
                if (assemblyType != null)
                {
                    var argTypes = new Type[] { };
                    ConstructorInfo constructorInfo = assemblyType.GetConstructor(argTypes);
                    return (T) constructorInfo?.Invoke(null);
                }
            }

            return null;
        }
    }
}