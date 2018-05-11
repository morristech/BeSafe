using System;

namespace BeSafe.Watchers.Types
{
    public class ModuleInfo
    {
        public UInt32 ProcessId { get; set; }
        public string ModulePath { get; set; }

        public new string ToString()
        {
            return $"PID:{ProcessId},ModulePath:{ModulePath}";
        }
    }
}