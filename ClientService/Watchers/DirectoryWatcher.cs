using System;
using System.IO;
using ExceptionManager;

namespace BeSafe.Watchers
{
    public class DirectoryWatcher
    {
        public delegate void FileChangeEventHandler(Types.FileInfo fileInfo);
        public FileChangeEventHandler OnFileChange;

        private readonly FileSystemWatcher directoryChangeWatcher;

        public DirectoryWatcher(string directoryPath)
        {
            directoryChangeWatcher = new FileSystemWatcher(directoryPath, "*.*")
            {
                NotifyFilter = NotifyFilters.LastWrite,
                IncludeSubdirectories = true,
                InternalBufferSize = 16384,
            };

            directoryChangeWatcher.Changed += new FileSystemEventHandler(OnChanged_EventArrived);
            directoryChangeWatcher.EnableRaisingEvents = true;
        }

        private void OnChanged_EventArrived(object sender, FileSystemEventArgs e)
        {
            OnFileChange?.Invoke(new Types.FileInfo
            {
                Path = e.FullPath,
                Name = e.Name,
                LastWrite = DateTime.Now
            });
        }

        public bool Stop()
        {
            try
            {
                directoryChangeWatcher.EnableRaisingEvents = false;
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