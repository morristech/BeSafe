using System;
using ExceptionManager;
using System.Management;
using BeSafe.Properties;
using BeSafe.Watchers.Types;

namespace BeSafe.Watchers
{
    public class ProcessWatcher
    {
        public delegate void NewProcessEventHandler(ProcessInfo processInfo);
        public NewProcessEventHandler OnNewProcess;

        private readonly ManagementEventWatcher _processStartWatcher = new ManagementEventWatcher(Resources.ProcessWatcherQuery);

        public ProcessWatcher()
        {
            try
            {
                _processStartWatcher.EventArrived += processStartEvent_EventArrived;
                _processStartWatcher.Start();
            }
            catch (Exception ex)
            {
                ex.LogToFile(ExceptionType.Service);
            }
        }

        private void processStartEvent_EventArrived(object sender, EventArrivedEventArgs e)
        {
            UInt32 processId = Convert.ToUInt32(e.NewEvent.Properties[Resources.ProcessIDField].Value);

            OnNewProcess?.Invoke(new ProcessInfo
            {
                ProcessId = processId,
                ParentProcessId = Convert.ToUInt32(e.NewEvent.Properties[Resources.ParentProcessIDFiled].Value),
                ProcessName = e.NewEvent.Properties[Resources.ProcessNameField].Value.ToString(),
                ExecutablePath = GetProcessExceutablePathByPid(processId)
            });
        }

        private string GetProcessExceutablePathByPid(UInt32 pid)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(string.Format(Resources.ExecutablaPathQuery, pid));

                foreach (var managementObject in searcher.Get())
                {
                    ManagementObject item = (ManagementObject)managementObject;
                    object executablePath = item[Resources.ExecutablePathField];

                    if (string.IsNullOrEmpty(executablePath?.ToString()))
                        continue;

                    return executablePath.ToString();
                }
            }
            catch (ManagementException ex)
            {
                ex.LogToFile();
            }

            return null;
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
                ex.LogToFile(ExceptionType.Service);
                return false;
            }
        }
    }
}