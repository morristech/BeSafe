using System;
using Microsoft.Win32;

namespace SharedTypes.Watchers.RegistryWatcherTypes
{
    [Serializable]
    public class RegistryMonitorPath
    {
        public RegistryHive RegistryHive { get; set; }

        public string RegistryKeyPath { get; set; }
    }
}