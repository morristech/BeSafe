using Microsoft.Win32;

namespace SharedTypes.Watchers.RegistryWatcherTypes
{
    public class RegistryMonitorPath
    {
        public RegistryHive RegistryHive { get; set; }

        public string RegistryKeyPath { get; set; }
    }
}