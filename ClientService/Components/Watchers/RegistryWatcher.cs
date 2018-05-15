using System;
using System.Linq;
using System.Threading;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Win32;
using BeSafe.Core.Utils;
using BeSafe.Components.Watchers.Types.RegistryWatcherTypes;
using ExceptionManager;

namespace BeSafe.Components.Watchers
{
    public class RegistryWatcher
    {
        public delegate void NewRegistryValueChangeEventHandler(ChangedValueInfo valueInfo);
        public event NewRegistryValueChangeEventHandler ValueChanged;

        List<RegistryMonitorPath> _mustMonitorRegistryPathes;
        private CancellationTokenSource _cancelToken = new CancellationTokenSource();
        private const int ValueRegChangeNotifyFilter = 4;


        public RegistryWatcher(List<RegistryMonitorPath> mustMonitorRegistryPathes)
        {
            _mustMonitorRegistryPathes = mustMonitorRegistryPathes;
        }

        public bool Start()
        {
            try
            {
                foreach (var mustWatchPath in _mustMonitorRegistryPathes)
                {
                    Task.Run(() =>
                    {
                        MonitorKeyLoop(mustWatchPath);
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
                _cancelToken.Cancel();
                return true;
            }
            catch (Exception ex)
            {
                ex.Log(ExceptionType.Service);
                return false;
            }
        }

        private void MonitorKeyLoop(RegistryMonitorPath registryPath)
        {
            IntPtr registryKey;
            int result = Win32APIDefinitions.RegOpenKeyEx((IntPtr)registryPath.RegistryHive, registryPath.RegistryKeyPath, 0, Win32APIDefinitions.STANDARD_RIGHTS_READ | Win32APIDefinitions.KEY_QUERY_VALUE | Win32APIDefinitions.KEY_NOTIFY,
                                      out registryKey);

            if (result != 0)
                return;

            try
            {
                AutoResetEvent _eventNotify = new AutoResetEvent(false);
                WaitHandle[] waitHandles = new WaitHandle[] { _eventNotify };
                while (!_cancelToken.IsCancellationRequested)
                {
                    List<KeyValuePair<string, string>> cachedValues = GetNamesAndValuesOfRegistryKey(registryPath.RegistryHive, registryPath.RegistryKeyPath).ToList();

                    result = Win32APIDefinitions.RegNotifyChangeKeyValue(registryKey, true, ValueRegChangeNotifyFilter, _eventNotify.SafeWaitHandle, true);
                    if (result != 0)
                        throw new Win32Exception(result);

                    if (WaitHandle.WaitAny(waitHandles) == 0)
                    {
                        List<KeyValuePair<string, string>> currentValues = GetNamesAndValuesOfRegistryKey(registryPath.RegistryHive, registryPath.RegistryKeyPath).ToList();

                        string keyDiff = currentValues.Select(field => field.Key).Except(cachedValues.Select(field => field.Key)).FirstOrDefault();
                        string valueDiff = currentValues.Select(field => field.Value).Except(cachedValues.Select(field => field.Value)).FirstOrDefault();

                        if (keyDiff == null && valueDiff == null)
                            continue;

                        if (valueDiff != null && keyDiff == null)
                            keyDiff = currentValues.FirstOrDefault(f => f.Value == valueDiff).Key;

                        cachedValues = currentValues;

                        ValueChanged?.Invoke(new ChangedValueInfo
                        {
                            MonitorPath = registryPath,
                            KeyValue = new KeyValuePair<string, string>(keyDiff, valueDiff)
                        });
                    }
                }
            }
            finally
            {
                if (registryKey != IntPtr.Zero)
                    Win32APIDefinitions.RegCloseKey(registryKey);
            }
        }

        private IEnumerable<KeyValuePair<string, string>> GetNamesAndValuesOfRegistryKey(RegistryHive hive, string path)
        {
            RegistryKey regKey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64);
            regKey = regKey.OpenSubKey(path);

            List<string> keyNames = regKey.GetValueNames().ToList();

            foreach (string keyName in keyNames)
            {
                RegistryValueKind valueKind = regKey.GetValueKind(keyName);
                if ((valueKind == RegistryValueKind.String) || (valueKind == RegistryValueKind.ExpandString))
                {
                    string valueOfKey = (string)regKey.GetValue(keyName);
                    yield return new KeyValuePair<string, string>(keyName, valueOfKey);
                }
            }
        }
    }
}
