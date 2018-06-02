using System;
using System.IO;
using PluginSample.Properties;
using PluginSDK;
using PluginSDK.PluginInterfaces;

namespace PluginSample
{
    public class BatchFileScanner : IBeSafeFilePlugin
    {
        private readonly PluginInfo _pluginInfo;

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

        public PluginResult Scan(string filePath, bool canFightWithThreat)
        {
            if (canFightWithThreat)
            {
                string quarantineFilePath = filePath + Resources.BeSafeQuarantineFileExt;
                File.Move(filePath, quarantineFilePath);
            }

            return new PluginResult
            {
                PluginInfo = _pluginInfo,
                ScannedObject = filePath,
                RiskRate = ThreatRiskRates.HighRisk,
                Message = "Be careful, Most of the times batch files are dangerous !",
                ExtraInfo = "https://en.wikipedia.org/wiki/Batch"
            };
        }
    }
}