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

        private ProcessWatcher processWatcher = new ProcessWatcher();
        private Queue<ProcessInfo> ExecutedProcessStack = new Queue<ProcessInfo>();

        public ProcessRegulator()
        {
            processWatcher.NewProcess += NewProcessArrived;
        }

        public void Config(BeSafeConfig config, PipeServer pipeServer, bool stoppingService)
        {
            bool stateResult = 
                (((config?.ComponentsState.ProcessWatcher == true) && (stoppingService == false)) 
                ? processWatcher.Start() 
                : processWatcher.Stop());
        }

        private void NewProcessArrived(ProcessInfo processInfo)
        {
            // TODO Scan engines not implemented yet, after they get ready use theme to scan process here :)
            ExecutedProcessStack.Enqueue(processInfo);
            Debug.WriteLine(processInfo.ToString());
        }
    }
}