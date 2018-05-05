using System;
using Microsoft.Win32;
using BeSafe.Properties;
using ExceptionManager;

namespace BeSafe.Initializer
{
    public class DriveView : IDisposable
    {
        private char _driveLetter;
        private RegistryKey _driveSpecificKey = Registry.CurrentUser;

        public DriveView(string driveLetter)
        {
            if (string.IsNullOrEmpty(driveLetter))
                return;

            _driveLetter = driveLetter[0];

            string driveSpecificRegistryPath = $@"{Resources.ExplorerDrivesRegistryPath}\{_driveLetter.ToString()}";
            try
            {
                _driveSpecificKey = _driveSpecificKey.CreateSubKey(driveSpecificRegistryPath);
            }
            catch (Exception ex)
            {
                ex.Log(ExceptionType.Service);
                return;
            }
        }

        public bool SetDriveIcon(string iconPath)
        {
            if (_driveSpecificKey == null)
                return false;

            try
            {
                _driveSpecificKey.CreateSubKey("DefaultIcon")?.SetValue(null, iconPath);
            }
            catch (Exception ex)
            {
                ex.Log(ExceptionType.Service);
                return false;
            }

            return true;
        }

        public bool SetDriveLabel(string label)
        {
            if (_driveSpecificKey == null)
                return false;

            try
            {
                _driveSpecificKey.CreateSubKey("DefaultLabel")?.SetValue(null, label);
            }
            catch (Exception ex)
            {
                ex.Log(ExceptionType.Service);
                return false;
            }

            return true;
        }

        public bool RemoveDriveView()
        {
            if (_driveSpecificKey == null)
                return false;

            var registry = Registry.CurrentUser;
            try
            {
                registry = registry.OpenSubKey(Resources.ExplorerDrivesRegistryPath, true);
                registry.DeleteSubKeyTree(_driveLetter.ToString());
            }
            catch (Exception ex)
            {
                ex.Log(ExceptionType.Service);
                return false;
            }

            return true;
        }

        public void Dispose()
        {
            _driveSpecificKey?.Close();
        }
    }
}