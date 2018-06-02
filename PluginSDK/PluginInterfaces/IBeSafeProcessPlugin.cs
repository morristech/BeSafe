using SharedTypes.Watchers;

namespace PluginSDK.PluginInterfaces
{
    public interface IBeSafeProcessPlugin
    {
        PluginInfo GetPluginInfo();
        PluginResult Scan(ProcessInfo processInfo, bool canFightWithThreat);
    }
}