using System;
using SharedTypes.Watchers;
using SharedTypes.Watchers.RegistryWatcherTypes;

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

                case PluginType.Process:
                    {
                        ProcessInfo pInfo = (ProcessInfo)ScannedObject;
                        scannedObjectString = $@"{pInfo.ProcessId} : {pInfo.ProcessName}{Environment.NewLine}Parent : {pInfo.ParentProcessId}";
                    }
                    break;

                case PluginType.Module:
                    {
                        ModuleInfo mInfo = (ModuleInfo)ScannedObject;
                        scannedObjectString = $@"{mInfo.ProcessId}";
                    }
                    break;
            }

            return $"{PluginInfo.Name}{Environment.NewLine}" +
                     $"{Message}{Environment.NewLine}" +
                    $"{scannedObjectString}";
        }
    }
}