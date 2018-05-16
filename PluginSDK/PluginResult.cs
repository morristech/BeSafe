using System;

namespace PluginSDK
{
    [Serializable]
    public class PluginResult
    {
        public PluginInfo PluginInfo;
        public dynamic ScannedObject;
        public ThreatRiskRates RiskRate;
        public string Message;
        public dynamic ExtraInfo;
    }
}