using PluginSDK;
using System.Collections.Generic;

namespace BeSafe.Core.Regulators.PluginRegulators
{
    interface IPlugin
    {
        PluginResult Scan(List<IBeSafePlugin> plugins, dynamic scanObject, bool canFight);
    }
}