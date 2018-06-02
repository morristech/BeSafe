namespace PluginSDK.PluginInterfaces
{
    public interface IBeSafeFilePlugin
    {
        PluginInfo GetPluginInfo();
        PluginResult Scan(string filePath, bool canFightWithThreat);
    }
}