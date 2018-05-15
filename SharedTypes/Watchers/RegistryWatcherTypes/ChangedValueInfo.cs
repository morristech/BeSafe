using System.Collections.Generic;

namespace SharedTypes.Watchers.RegistryWatcherTypes
{
    public class ChangedValueInfo
    {
        public RegistryMonitorPath MonitorPath{get;set;}

        public KeyValuePair<string, string> KeyValue { get; set; }

        public new string ToString()
        {
            return $@"{MonitorPath.RegistryHive}\{MonitorPath.RegistryKeyPath} - {KeyValue.Key} = {KeyValue.Value}";
        }
    }
}