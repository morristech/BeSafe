using System.Linq;
using System.Collections.Generic;
using Common.Utils;
using ConfigManager;
using PluginSDK;
using PluginSDK.PluginInterfaces;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    public class PluginProxy : IPluginProxy
    {
        #region Singleton

        private static PluginProxy SingletonInstance;

        public static PluginProxy Instance(BeSafeConfig config) =>
            (SingletonInstance ?? (SingletonInstance = new PluginProxy(config)));

        #endregion

        private readonly BeSafeConfig _config;

        private readonly PluginUtils _pluginUtils = new PluginUtils();

        public PluginProxy(BeSafeConfig config)
        {
            _config = config;
        }

        public PluginResult Scan(dynamic scanObject, PluginType type)
        {
            bool canFight = _config.ComponentsState.FightWithThreats;

            switch (type)
            {
                case PluginType.File:
                {
                    Dictionary<string, IBeSafeFilePlugin> plugins = _pluginUtils.GetPluginsInfo<IBeSafeFilePlugin>(_config.PluginsPath);
                    if (plugins.Any())
                        return SecureVolumePluginRegulator.Instance().Scan(plugins, scanObject, canFight);
                }
                    break;

                case PluginType.Registry:
                {
                    Dictionary<string, IBeSafeRegistryPlugin> plugins = _pluginUtils.GetPluginsInfo<IBeSafeRegistryPlugin>(_config.PluginsPath);
                    if (plugins.Any())
                        return RegistryPluginRegulator.Instance().Scan(plugins, scanObject, canFight);
                }
                    break;

                case PluginType.Process:
                {
                    Dictionary<string, IBeSafeProcessPlugin> plugins = _pluginUtils.GetPluginsInfo<IBeSafeProcessPlugin>(_config.PluginsPath);
                    if (plugins.Any())
                        return ProcessPluginRegulator.Instance().Scan(plugins, scanObject, canFight);
                }
                    break;

                case PluginType.Module:
                {
                    Dictionary<string, IBeSafeModulePlugin> plugins =
                        _pluginUtils.GetPluginsInfo<IBeSafeModulePlugin>(_config.PluginsPath);
                    if (plugins.Any())
                        return ModulePluginRegulator.Instance().Scan(plugins, scanObject, canFight);
                }
                    break;

                default:
                    return null;
            }

            return null;
        }
    }
}