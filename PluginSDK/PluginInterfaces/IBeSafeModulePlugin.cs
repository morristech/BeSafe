using SharedTypes.Watchers;

namespace PluginSDK.PluginInterfaces
{
    public interface IBeSafeModulePlugin : IBeSafeBasePlugin
    {
        PluginResult Scan(ModuleInfo moduleInfo, bool canFightWithThreat);
    }
}