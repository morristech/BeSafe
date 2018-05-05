using System;
using System.Management;
using BeSafe.Watchers.Types;
using ExceptionManager;
using BeSafe.Properties;

namespace BeSafe.Watchers
{
    public class ModuleWatcher
    {
        public delegate void LoadModuleEventHandler(ModuleInfo moduleInfo);
        public LoadModuleEventHandler OnLoadModule;

        readonly ManagementEventWatcher _moduleLoadEvent = new ManagementEventWatcher(Resources.ModuleWatcherQuery);

        public ModuleWatcher()
        {
            try
            {
                _moduleLoadEvent.EventArrived += moduleLoadEvent_EventArrived;
                _moduleLoadEvent.Start();
            }
            catch (Exception ex)
            {
                ex.LogToFile(ExceptionType.Service);
            }
        }

        private void moduleLoadEvent_EventArrived(object sender, EventArrivedEventArgs e)
        {
            OnLoadModule?.Invoke(new ModuleInfo
            {
                ProcessId = Convert.ToUInt32(e.NewEvent.Properties[Resources.ProcessIdField].Value),
                ModulePath = e.NewEvent.Properties[Resources.FileNameField].Value.ToString()
            });
        }

        public bool Stop()
        {
            try
            {
                _moduleLoadEvent.Stop();
                return true;
            }
            catch (Exception ex)
            {
                ex.LogToFile(ExceptionType.Service);
                return false;
            }
        }
    }
}