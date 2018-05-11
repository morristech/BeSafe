namespace PluginSDK
{
    public interface IBeSafePlugin
    {
        PluginInfo GetPluginInfo();
        PluginResult ScanFile(dynamic parameters);
    }
}