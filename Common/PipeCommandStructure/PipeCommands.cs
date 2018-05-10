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
        ReloadPlugins,
        Error =4,
    }
}