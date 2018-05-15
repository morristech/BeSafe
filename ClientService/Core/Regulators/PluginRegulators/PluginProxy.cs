using System.Linq;
using System.Collections.Generic;
using Common.Utils;
using ConfigManager;
using PluginSDK;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    public class PluginProxy : IPluginProxy
    {
        #region Singleton
        private static PluginProxy SingletonInstance;
        public static PluginProxy Instance(BeSafeConfig config) => (SingletonInstance ?? (SingletonInstance = new PluginProxy(config)));
        #endregion

        private readonly BeSafeConfig _config;

        private readonly PluginUtils pluginUtils = new PluginUtils();

        public PluginProxy(BeSafeConfig config)
        {
            _config = config;
        }

        public PluginResult Scan(dynamic scanObject, PluginType type)
        {
            List<IBeSafePlugin> plugins = pluginUtils.GetPluginsInfo(_config.PluginsPath).Where(w => w.GetPluginInfo().Type == type).ToList();
            if ((plugins == null) || (! plugins.Any()))
                return null;

            bool canFight = _config.ComponentsState.FightWithThreats;

            switch (type)
            {
                case PluginType.File:
                    return SecureVolumePluginRegulator.Instance().Scan(plugins, scanObject, canFight);

                case PluginType.Registry:
                    return RegistryPluginRegulator.Instance().Scan(plugins, scanObject, canFight);

                case PluginType.Process:
                    return null;

                case PluginType.Module:
                    return null;

                default:
                    return null;
            }
        }
    }
}