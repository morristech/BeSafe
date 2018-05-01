using System;
using System.Management;
using BeSafe.Watchers.Types;
using ExceptionManager;

namespace BeSafe.Watchers
{
    public class ModuleWatcher
    {
        public delegate void LoadModuleEventHandler(ModuleInfo moduleInfo);
        public LoadModuleEventHandler OnLoadModule;

        readonly ManagementEventWatcher _moduleLoadEvent = new ManagementEventWatcher("SELECT ProcessID, FileName FROM Win32_ModuleLoadTrace");

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
                ProcessId = Convert.ToUInt32(e.NewEvent.Properties["ProcessID"].Value),
                ModulePath = e.NewEvent.Properties["FileName"].Value.ToString()
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