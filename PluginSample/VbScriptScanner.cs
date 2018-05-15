using System;
using System.IO;
using PluginSample.Properties;
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
            string filePath = (string)parameters;

            if (canFightWithThreat)
            {
                string quarantineFilePath = filePath + Resources.BeSafeQuarantineFileExt;
                File.Move(filePath, quarantineFilePath);
            }

            return new PluginResult
            {
                ScannedObject = (string)parameters,
                Threat = true,
                RiskRate = ThreatRiskRates.HighRisk,
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