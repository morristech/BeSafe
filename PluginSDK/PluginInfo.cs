using System;

namespace PluginSDK
{
    public class PluginInfo
    {
        public string Name;
        public Version Version;
        public PluginType Type;
        public string Description;

        public override string ToString()
        {
            return $"{Name} {Version} ({Description})";
        }
    }
}