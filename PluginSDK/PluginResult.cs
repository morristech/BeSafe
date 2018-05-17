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
        public string ExtraInfo;
        public string ScannedObjectString
        {
            get
            {
                switch (PluginInfo.Type)
                {
                    case PluginType.File:
                        return (string)ScannedObject;

                    case PluginType.Registry:
                        {
                            ChangedValueInfo so = (ChangedValueInfo)ScannedObject;
                            return so.ToString();
                        }

                    case PluginType.Process:
                        {
                            ProcessInfo pInfo = (ProcessInfo)ScannedObject;
                            return $@"{pInfo.ProcessId} : {pInfo.ProcessName}{Environment.NewLine}Parent : {pInfo.ParentProcessId}";
                        }

                    case PluginType.Module:
                        {
                            ModuleInfo mInfo = (ModuleInfo)ScannedObject;
                            return $@"{mInfo.ProcessId}";
                        }

                    default:
                        return string.Empty;
                }
            }
        }

        public new string ToString()
        {
            return $"{PluginInfo.Name}{Environment.NewLine}" +
                     $"{Message}{Environment.NewLine}" +
                    $"{ScannedObjectString}";
        }
    }
}