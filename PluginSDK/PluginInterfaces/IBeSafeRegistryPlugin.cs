using SharedTypes.Watchers.RegistryWatcherTypes;

namespace PluginSDK.PluginInterfaces
{
    public interface IBeSafeRegistryPlugin : IBeSafeBasePlugin
    {
        PluginResult Scan(ChangedValueInfo registryKeyInfo, bool canFightWithThreat);
    }
}