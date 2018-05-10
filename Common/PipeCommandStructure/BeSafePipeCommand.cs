using System;

namespace Common.PipeCommandStructure
{
    [Serializable]
    public class BeSafePipeCommand
    {
        public ClientServiceItems Item;
        public PipeCommands Command;
        public string ExtraData;
    }
}