using System;

namespace ConfigManager
{
    [Serializable]
    public class ComponentsEnableState
    {
        public bool SecureVolume;
        public bool ProcessWatcher;
        public bool ModuleWatcher;
        public bool RegistryWatcher;
        public bool StaticScanEngine;
        public bool DynamicScanEngine;
        public bool VirusTotalEngine;
        public bool YaraEngine;
        public bool FightWithThreats;
    }
}