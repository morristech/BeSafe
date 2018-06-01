using System.Diagnostics;
using System.Collections.Generic;
using BeSafe.Components.Watchers;
using ConfigManager;
using BeSafe.Core.Utils;
using SharedTypes.Watchers;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    public class ProcessRegulator : IComponentRegulator
    {
        #region Singleton
        private static ProcessRegulator SingletonInstance;
        public static ProcessRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new ProcessRegulator()));
        #endregion

        private readonly ProcessWatcher _processWatcher = new ProcessWatcher();
        private readonly Queue<ProcessInfo> _executedProcessStack = new Queue<ProcessInfo>();

        private ProcessRegulator()
        {
            _processWatcher.NewProcess += NewProcessArrived;
        }

        public void Config(BeSafeConfig config, PipeServer pipeServer, bool stoppingService)
        {
            bool stateResult = 
                (((config?.ComponentsState.ProcessWatcher == true) && (stoppingService == false)) 
                ? _processWatcher.Start() 
                : _processWatcher.Stop());
        }

        private void NewProcessArrived(ProcessInfo processInfo)
        {
            // TODO Scan engines not implemented yet, after they get ready use theme to scan process here :)
            _executedProcessStack.Enqueue(processInfo);
            Debug.WriteLine(processInfo.ToString());
        }
    }
}