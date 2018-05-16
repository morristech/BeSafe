using PluginSDK;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    public interface IPluginProxy
    {
        PluginResult Scan(dynamic scanObject, PluginType type);
    }
}