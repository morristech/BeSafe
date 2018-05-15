using PluginSDK;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    interface IPluginRegulator
    {
        PluginResult Scan(dynamic scanObject, PluginType type);
    }
}