using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using ExceptionManager;

namespace BeSafe.Components.Watchers
{
    public class DirectoryWatcher
    {
        public FileSystemEventHandler DirectoryChanged;

        readonly List<string> _mustMonitorDirectories;
        private readonly CancellationTokenSource _cancelToken = new CancellationTokenSource();
        private readonly List<FileSystemWatcher> _watchers = new List<FileSystemWatcher>();

        public DirectoryWatcher(List<string> mustMonitorDirectories)
        {
            _mustMonitorDirectories = mustMonitorDirectories;
        }

        public bool Start()
        {
            try
            {
                if (DirectoryChanged == null)
                    return false;

                foreach (var watchPath in _mustMonitorDirectories)
                {
                    Task.Run(() =>
                    {
                        FileSystemWatcher watcher = new FileSystemWatcher
                        {
                            Path = watchPath,
                            NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName,
                            Filter = "*.*"
                        };
                        watcher.Changed += DirectoryChanged;
                        watcher.EnableRaisingEvents = true;

                        _watchers.Add(watcher);

                    }, _cancelToken.Token);
                }
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
                foreach (FileSystemWatcher watcher in _watchers)
                    watcher.EnableRaisingEvents = false;

                _cancelToken.Cancel();
                return true;
            }
            catch (Exception ex)
            {
                ex.Log(ExceptionType.Service);
                return false;
            }
        }
    }
}