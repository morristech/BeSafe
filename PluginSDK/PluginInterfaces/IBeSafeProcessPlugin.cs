using SharedTypes.Watchers;

namespace PluginSDK.PluginInterfaces
{
    public interface IBeSafeProcessPlugin : IBeSafeBasePlugin
    {
        PluginResult Scan(ProcessInfo processInfo, bool canFightWithThreat);
    }
}