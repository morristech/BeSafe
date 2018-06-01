using System;
using System.IO;
using System.Threading;
using BeSafe.Components.Watchers;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using PluginSDK;
using ConfigManager;
using BeSafe.Core.Utils;
using Common.PipeCommandStructure;
using BeSafe.Core.Regulators.PluginRegulators;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    public class DirectoryRegulator : IComponentRegulator
    {
        #region Singleton
        private static DirectoryRegulator SingletonInstance;
        public static DirectoryRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new DirectoryRegulator()));
        #endregion

        private DirectoryWatcher _directoryWatcher;
        private readonly ConcurrentQueue<string> _changedDirectoryQueue = new ConcurrentQueue<string>();

        private BeSafeConfig _config;
        private PipeServer _pipeServer;

        public DirectoryRegulator()
        {
            _directoryWatcher.DirectoryChanged += DirectoryChanged;
        }

        public void Config(BeSafeConfig config, PipeServer pipeServer, bool stoppingService)
        {
            _config = config;
            _pipeServer = pipeServer;

            bool stateResult;

            if ((config?.ComponentsState.RegistryWatcher == true) && (stoppingService == false))
            {
                _directoryWatcher = new DirectoryWatcher(new List<string>
                {
                    
                });

                _directoryWatcher.DirectoryChanged += DirectoryChanged;
                stateResult = _directoryWatcher.Start();

                Task.Run(() => StackScanner(_changedDirectoryQueue));
                return;
            }

            stateResult = _directoryWatcher?.Stop() ?? false;
        }

        private void DirectoryChanged(object sender, FileSystemEventArgs e)
        {
            _changedDirectoryQueue.Enqueue(e.FullPath);
        }

        private void StackScanner(ConcurrentQueue<string> queue)
        {
            while (true)
            {
                queue.TryDequeue(out var changedObjectPath);

                if (string.IsNullOrEmpty(changedObjectPath))
                    continue;

                PluginResult scanResult = PluginProxy.Instance(_config).Scan(changedObjectPath, PluginType.File);

                if (scanResult.RiskRate != ThreatRiskRates.NoRisk)
                {
                    bool? sendCommandResult = _pipeServer?.SendCommandToUI(new BeSafePipeCommand
                    {
                        CommandId = Guid.NewGuid(),
                        Command = PipeCommands.PluginScanResult,
                        PluginScanResult = scanResult
                    });

                    // Log threat
                    ThreatLog.Log(scanResult);
                }

                Thread.Sleep(500);
            }
        }
    }
}