﻿using System;

namespace Common.PipeCommandStructure
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
    }
}