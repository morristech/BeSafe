using SharedTypes.Watchers;

namespace PluginSDK.PluginInterfaces
{
    public interface IBeSafeModulePlugin
    {
        PluginInfo GetPluginInfo();
        PluginResult Scan(ModuleInfo moduleInfo, bool canFightWithThreat);
    }
}