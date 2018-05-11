using System.Diagnostics;
using System.Collections.Generic;
using BeSafe.Watchers;
using BeSafe.Watchers.Types;

namespace BeSafe.ComponentsConfigurator
{
    public class ProcessConfigurator : IConfigurator
    {
        #region Singleton
        private static ProcessConfigurator SingletonInstance;
        public static ProcessConfigurator Instance() => (SingletonInstance ?? (SingletonInstance = new ProcessConfigurator()));
        #endregion

        private ProcessWatcher processWatcher = new ProcessWatcher();
        private Stack<ProcessInfo> ExecutedProcessStack = new Stack<ProcessInfo>();

        public ProcessConfigurator()
        {
            processWatcher.NewProcess += NewProcessArrived;
        }

        public void Config(bool enableState)
        {
            bool stateResult = (enableState == true ? processWatcher.Start() : processWatcher.Stop());
        }

        private void NewProcessArrived(ProcessInfo processInfo)
        {
            // TODO Scan engines not implemented yet, after they get ready use theme to scan process here :)
            ExecutedProcessStack.Push(processInfo);
            Debug.WriteLine(processInfo.ToString());
        }
    }
}