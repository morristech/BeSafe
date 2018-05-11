using BeSafe.Watchers;
using BeSafe.Watchers.Types;
using System;
using System.Diagnostics;

namespace BeSafe.ComponentsConfigurator
{
    public class ProcessConfigurator : IConfigurator
    {
        #region Singleton
        private static ProcessConfigurator SingletonInstance;
        public static ProcessConfigurator Instance() => (SingletonInstance ?? (SingletonInstance = new ProcessConfigurator()));
        #endregion

        private ProcessWatcher processWatcher = new ProcessWatcher();

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
            Debug.WriteLine(processInfo.ToString());
        }
    }
}