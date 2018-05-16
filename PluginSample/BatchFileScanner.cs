using System;
using System.IO;
using PluginSample.Properties;
using PluginSDK;

namespace PluginSample
{
    public class BatchFileScanner : IBeSafePlugin
    {
        private PluginInfo _pluginInfo;

        public BatchFileScanner()
        {
            _pluginInfo = new PluginInfo
            {
                Name = "Batch File Scanner",
                Version = new Version(1, 0),
                Type = PluginType.File,
                Description = ".bat"
            };
        }

        public PluginInfo GetPluginInfo()
        {
            return _pluginInfo;
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
                PluginInfo = _pluginInfo,
                ScannedObject = parameters,
                RiskRate = ThreatRiskRates.HighRisk,
                Message = "Be careful, Most of the times batch files are dangerous !",
                ExtraInfo = "https://en.wikipedia.org/wiki/Batch"
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