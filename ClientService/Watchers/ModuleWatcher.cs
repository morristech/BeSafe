using System;
using System.Management;
using ExceptionManager;
using BeSafe.Properties;
using BeSafe.Watchers.Types;

namespace BeSafe.Watchers
{
    public class ModuleWatcher
    {
        public delegate void LoadModuleEventHandler(ModuleInfo moduleInfo);
        public LoadModuleEventHandler LoadModule;

        readonly ManagementEventWatcher _moduleLoadEvent = new ManagementEventWatcher(Resources.ModuleWatcherQuery);

        public ModuleWatcher()
        {
            _moduleLoadEvent.EventArrived += moduleLoadEvent_EventArrived;
        }

        public bool Start()
        {
            try
            {
                _moduleLoadEvent.Start();
                return true;
            }
            catch (Exception ex)
            {
                ex.Log(ExceptionType.Service);
                return false;
            }
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
                ex.Log(ExceptionType.Service);
                return false;
            }
        }

        private void moduleLoadEvent_EventArrived(object sender, EventArrivedEventArgs e)
        {
            LoadModule?.Invoke(new ModuleInfo
            {
                ProcessId = Convert.ToUInt32(e.NewEvent.Properties[Resources.ProcessIDField].Value),
                ModulePath = e.NewEvent.Properties[Resources.FileNameField].Value.ToString()
            });
        }
    }
}