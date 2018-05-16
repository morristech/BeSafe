using System;
using PluginSDK;

namespace Common.PipeCommandStructure
{
    [Serializable]
    public class BeSafePipeCommand
    {
        public Guid CommandId;
        public PipeCommands Command;
        public string Notification;
        public string ConfigFilePath;
        public PluginResult PluginScanResult;
    }
}