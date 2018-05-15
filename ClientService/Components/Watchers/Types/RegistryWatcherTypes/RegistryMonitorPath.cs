using Microsoft.Win32;

namespace BeSafe.Components.Watchers.Types.RegistryWatcherTypes
{
    public class RegistryMonitorPath
    {
        public RegistryHive RegistryHive { get; set; }

        public string RegistryKeyPath { get; set; }
    }
}