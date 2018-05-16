using System;

namespace Common.PipeCommandStructure
{
    [Serializable]
    public enum PipeCommands
    {
        Stop = 0,
        Start = 1,
        ComponentConfiguration = 2,
        Notification = 3,
        Error =4,
        ReloadPlugins = 5,
        PluginScanResult = 6
    }
}