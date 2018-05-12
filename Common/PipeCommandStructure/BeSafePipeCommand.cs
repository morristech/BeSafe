using System;

namespace Common.PipeCommandStructure
{
    [Serializable]
    public class BeSafePipeCommand
    {
        public Guid CommandId;
        public PipeCommands Command;
        public string Notification;
        public string ConfigFilePath;
    }
}