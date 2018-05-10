using System;

namespace Common.PipeCommandStructure
{
    [Serializable]
    public class BeSafePipeCommand
    {
        public ComponentsEnableState ComponentsState;
        public PipeCommands Command;
        public string ExtraData;
    }
}