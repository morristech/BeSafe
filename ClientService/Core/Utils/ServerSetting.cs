using System;
using Microsoft.Win32;
using ExceptionManager;
using BeSafe.Properties;

namespace BeSafe.Core.Utils
{
    public class ServiceSetting : IDisposable
    {
        private RegistryKey _driveSpecificKey = Registry.LocalMachine;

        public ServiceSetting()
        {
            try
            {
                _driveSpecificKey = _driveSpecificKey.OpenSubKey(Resources.ServiceSettingRegistrypath, true);
                _driveSpecificKey = _driveSpecificKey.CreateSubKey(Resources.ApplicationName);
            }
            catch (Exception ex)
            {
                ex.Log(ExceptionType.Service);
                return;
            }
        }

        public bool StoreConfigFilePath(string confgFilePath)
        {
            if (_driveSpecificKey == null)
                return false;

            // If any path stored in this key, don't change it and just return it
            string lastStoredPath = RetriveConfigFilePath();
            if (!string.IsNullOrEmpty(lastStoredPath))
                return true;

            try
            {
                _driveSpecificKey.SetValue(Resources.ConfigFilePathRegistryValueName, confgFilePath);
            }
            catch (Exception ex)
            {
                ex.Log(ExceptionType.Service);
                return false;
            }

            return true;
        }

        public string RetriveConfigFilePath()
        {
            if (_driveSpecificKey == null)
                return null;

            var registry = Registry.LocalMachine;
            try
            {
                //registry = registry.OpenSubKey(Resources.ServiceSettingRegistrypath, true);
                return _driveSpecificKey.GetValue(Resources.ConfigFilePathRegistryValueName).ToString();
            }
            catch (Exception ex)
            {
                ex.Log(ExceptionType.Service);
                return null;
            }
        }

        public void Dispose()
        {
            _driveSpecificKey?.Close();
        }
    }
}