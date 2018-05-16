using SharedTypes.Watchers.RegistryWatcherTypes;
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

        public new string ToString()
        {
            string scannedObjectString = string.Empty;

            switch (PluginInfo.Type)
            {
                case PluginType.File:
                    scannedObjectString = (string)ScannedObject;
                    break;

                case PluginType.Registry:
                    {
                        ChangedValueInfo so = (ChangedValueInfo)ScannedObject;
                        scannedObjectString = $@"{so.MonitorPath.RegistryHive}\{so.MonitorPath}\{so.KeyValue.Key}";
                    }
                    break;
            }

            return $"{PluginInfo.Name}{Environment.NewLine}" +
                     $"{Message}{Environment.NewLine}" +
                    $"{scannedObjectString}";
        }
    }
}