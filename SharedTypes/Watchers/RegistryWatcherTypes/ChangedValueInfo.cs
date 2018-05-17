using System;

namespace SharedTypes.Watchers.RegistryWatcherTypes
{
    [Serializable]
    public class ChangedValueInfo
    {
        public RegistryMonitorPath MonitorPath { get; set; }

        public RegistryChangedObject ChangedObject { get; set; }

        public new string ToString()
        {
            return $@"{MonitorPath.RegistryHive}\{MonitorPath.RegistryKeyPath}{Environment.NewLine}{Environment.NewLine}" +
                $"Key : {ChangedObject.Key}{Environment.NewLine}" +
                $"Original Value : { ChangedObject.OriginalValue}{Environment.NewLine}" +
                $"Current Value : { ChangedObject.Value}";
        }
    }
}