using System;

namespace Common.PipeCommandStructure
{
    [Serializable]
    public enum ClientServiceItems
    {
        SecureVolume,
        ProcessWatcher,
        ModuleWatcher,
        StaticScanEngine,
        DynamicScanEngine,
        ProtectorDetectorEngine,
        VirusTotalEngine,
        YaraEngine,
    }
}