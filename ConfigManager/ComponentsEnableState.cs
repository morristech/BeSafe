using System;

namespace ConfigManager
{
    [Serializable]
    public class ComponentsEnableState
    {
        public bool SecureVolume;
        public bool ProcessWatcher;
        public bool ModuleWatcher;
        public bool StaticScanEngine;
        public bool DynamicScanEngine;
        public bool ProtectorDetectorEngine;
        public bool VirusTotalEngine;
        public bool YaraEngine;
        public bool AutoKill;
        public bool AutoQuarantine;
    }
}