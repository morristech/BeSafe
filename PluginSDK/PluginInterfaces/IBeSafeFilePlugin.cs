namespace PluginSDK.PluginInterfaces
{
    public interface IBeSafeFilePlugin : IBeSafeBasePlugin
    {
        PluginResult Scan(string filePath, bool canFightWithThreat);
    }
}