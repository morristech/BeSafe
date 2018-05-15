using PluginSDK;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    interface IPluginProxy
    {
        PluginResult Scan(dynamic scanObject, PluginType type);
    }
}