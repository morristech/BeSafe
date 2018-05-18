using System;
using System.IO;
using BeSafe.Components.Initializers;
using BeSafe.Components.Initializers.VirtualDrive;
using BeSafe.Core.Utils;
using ConfigManager;
using PluginSDK;
using BeSafe.Core.Regulators.PluginRegulators;
using Common.PipeCommandStructure;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    public class SecureVolumeRegulator : IComponentRegulator
    {
        #region Singleton
        private static SecureVolumeRegulator SingletonInstance;
        public static SecureVolumeRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new SecureVolumeRegulator()));
        #endregion

        private VirtualDrive secureDrive = new VirtualDrive();
        private DriveView driveView;

        private BeSafeConfig _config;
        private PipeServer _pipeServer;

        public void Config(BeSafeConfig config, PipeServer pipeServer, bool stoppingService)
        {
            _config = config;
            _pipeServer = pipeServer;

            if ((config != null) && (config.ComponentsState.SecureVolume) && (stoppingService == false))
            {
                secureDrive.FileAccessRequestEvent += OnFileAccessRequestEvent;
                string mappedDriveLetter = secureDrive.MapDrive(config.SecureVolumePath);

                driveView = new DriveView(mappedDriveLetter);
                driveView.SetDriveIcon($"{System.Reflection.Assembly.GetEntryAssembly().Location}");
            }
            else
            {
                DriveInfo beSafeDriveInfo = ServiceUtils.GetBeSafeDriveLetter();
                if (beSafeDriveInfo == null)
                    return;

                secureDrive.UnmapDrive(beSafeDriveInfo.Name);
                new DriveView(beSafeDriveInfo.Name).RemoveDriveView();
            }
        }

        private ThreatRiskRates OnFileAccessRequestEvent(string filePath)
        {
            PluginResult scanResult = PluginProxy.Instance(_config).Scan(filePath, PluginType.File);

            if (scanResult.RiskRate != ThreatRiskRates.NoRisk)
            {
                bool? sendCommandResult = _pipeServer?.SendCommandToUI(new BeSafePipeCommand
                {
                    CommandId = Guid.NewGuid(),
                    Command = PipeCommands.PluginScanResult,
                    PluginScanResult = scanResult
                });

                // Log threat
                ThreatLog.Instance().Add(scanResult);
            }

            return scanResult.RiskRate;
        }
    }
}