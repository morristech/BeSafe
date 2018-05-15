using System;
using PluginSDK;

namespace PluginSample
{
    public class VbScriptScanner : IBeSafePlugin
    {
        public PluginInfo GetPluginInfo()
        {
            return new PluginInfo
            {
                Name = "Script Scanner",
                Version = new Version(1, 0),
                Type = PluginType.File,
                Description = ".vb,.vbe,.vbs,.js,.ps1,.psd1,.psm1,.bat"
            };
        }

        public PluginResult ScanFile(dynamic parameters, bool canFightWithThreat)
        {
            return new PluginResult
            {
                ScannedObject = (string)parameters,
                Threat = true,
                Rate = 100,
                Message = "Be careful, Most of the times VBScript files are dangerous !",
                ExtraInfo = "https://en.wikipedia.org/wiki/VBScript"
            };
        }

        public PluginResult ScanModule(dynamic parameters, bool canFightWithThreat)
        {
            throw new NotImplementedException();
        }

        public PluginResult ScanProcess(dynamic parameters, bool canFightWithThreat)
        {
            throw new NotImplementedException();
        }

        public PluginResult ScanRegistry(dynamic parameters, bool canFightWithThreat)
        {
            throw new NotImplementedException();
        }
    }
}