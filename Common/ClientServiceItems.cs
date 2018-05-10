using System;

namespace Common
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