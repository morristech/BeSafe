using System;

namespace BeSafe.Watchers.Types
{
    public class FileInfo
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public DateTime LastWrite { get; set; }
    }
}