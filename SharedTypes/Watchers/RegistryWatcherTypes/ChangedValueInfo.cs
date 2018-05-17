using System;
using System.Collections.Generic;

namespace SharedTypes.Watchers.RegistryWatcherTypes
{
    [Serializable]
    public class ChangedValueInfo
    {
        public RegistryMonitorPath MonitorPath{get;set;}

        public RegistryChangedObject ChangedObject { get; set; }

        public new string ToString()
        {
            return $@"{MonitorPath.RegistryHive}\{MonitorPath.RegistryKeyPath} - {ChangedObject.Key} = {ChangedObject.Value}";
        }
    }
}