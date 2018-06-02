using SharedTypes.Watchers.RegistryWatcherTypes;

namespace PluginSDK.PluginInterfaces
{
    public interface IBeSafeRegistryPlugin
    {
        PluginInfo GetPluginInfo();
        PluginResult Scan(ChangedValueInfo registryKeyInfo, bool canFightWithThreat);
    }
}