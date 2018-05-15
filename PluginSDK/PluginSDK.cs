namespace PluginSDK
{
    public interface IBeSafePlugin
    {
        PluginInfo GetPluginInfo();
        PluginResult ScanFile(dynamic parameters, bool canFightWithThreat);
        PluginResult ScanRegistry(dynamic parameters, bool canFightWithThreat);
        PluginResult ScanProcess(dynamic parameters, bool canFightWithThreat);
        PluginResult ScanModule(dynamic parameters, bool canFightWithThreat);
    }
}