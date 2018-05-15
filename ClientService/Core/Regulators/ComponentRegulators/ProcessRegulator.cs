using System.Diagnostics;
using System.Collections.Generic;
using BeSafe.Components.Watchers;
using BeSafe.Components.Watchers.Types;
using ConfigManager;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    public class ProcessRegulator : IComponentRegulator
    {
        #region Singleton
        private static ProcessRegulator SingletonInstance;
        public static ProcessRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new ProcessRegulator()));
        #endregion

        private ProcessWatcher processWatcher = new ProcessWatcher();
        private Stack<ProcessInfo> ExecutedProcessStack = new Stack<ProcessInfo>();

        public ProcessRegulator()
        {
            processWatcher.NewProcess += NewProcessArrived;
        }

        public void Config(BeSafeConfig config, bool stoppingService)
        {
            bool stateResult = 
                (((config?.ComponentsState.ProcessWatcher == true) && (stoppingService == false)) 
                ? processWatcher.Start() 
                : processWatcher.Stop());
        }

        private void NewProcessArrived(ProcessInfo processInfo)
        {
            // TODO Scan engines not implemented yet, after they get ready use theme to scan process here :)
            ExecutedProcessStack.Push(processInfo);
            Debug.WriteLine(processInfo.ToString());
        }
    }
}