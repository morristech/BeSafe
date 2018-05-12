using System;
using ExceptionManager;
using System.Management;
using BeSafe.Properties;
using BeSafe.Components.Watchers.Types;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;

namespace BeSafe.Components.Watchers
{
    public class ProcessWatcher
    {
        public delegate void NewProcessEventHandler(ProcessInfo processInfo);
        public NewProcessEventHandler NewProcess;

        private readonly ManagementEventWatcher _processStartWatcher = new ManagementEventWatcher(Resources.ProcessWatcherQuery);

        public ProcessWatcher()
        {
            _processStartWatcher.EventArrived += processStartEvent_EventArrived;
        }

        public bool Start()
        {
            try
            {
                _processStartWatcher.Start();
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
                _processStartWatcher.Stop();
                return true;
            }
            catch (Exception ex)
            {
                ex.Log(ExceptionType.Service);
                return false;
            }
        }

        private void processStartEvent_EventArrived(object sender, EventArrivedEventArgs e)
        {
            UInt32 processId = Convert.ToUInt32(e.NewEvent.Properties[Resources.ProcessIDField].Value);

            NewProcess?.Invoke(new ProcessInfo
            {
                ProcessId = processId,
                ParentProcessId = Convert.ToUInt32(e.NewEvent.Properties[Resources.ParentProcessIDFiled].Value),
                ProcessName = e.NewEvent.Properties[Resources.ProcessNameField].Value.ToString(),
                ExecutablePath = Process.GetProcesses()?.FirstOrDefault(pr => pr.Id == processId)?.MainModule?.FileName
            });
        }
    }
}