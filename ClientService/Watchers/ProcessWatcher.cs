using System;
using System.Management;
using ExceptionManager;

namespace BeSafe.Watchers
{
    public class ProcessWatcher
    {
        readonly ManagementEventWatcher _processStartEvent = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStartTrace");

        public ProcessWatcher(EventArrivedEventHandler onProcessStartEventHandler)
        {
            try
            {
                _processStartEvent.EventArrived += onProcessStartEventHandler;
                _processStartEvent.Start();
            }
            catch (Exception ex)
            {
                ex.LogToFile(ExceptionType.Service);
            }
        }

        public bool Stop()
        {
            try
            {
                _processStartEvent.Stop();
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