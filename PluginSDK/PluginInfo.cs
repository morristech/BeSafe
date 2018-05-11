using System;
using System.Collections.Generic;

namespace PluginSDK
{
    public struct PluginInfo
    {
        public string Name;
        public Version Version;
        public List<string> SupportedFileTypes;
    }
}