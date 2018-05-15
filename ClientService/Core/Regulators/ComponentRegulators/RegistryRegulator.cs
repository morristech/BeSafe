using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Win32;
using ConfigManager;
using BeSafe.Components.Watchers;
using SharedTypes.Watchers.RegistryWatcherTypes;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    public class RegistryRegulator : IComponentRegulator
    {
        #region Singleton
        private static RegistryRegulator SingletonInstance;
        public static RegistryRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new RegistryRegulator()));
        #endregion

        private RegistryWatcher registryWatcher;
        private Stack<ChangedValueInfo> ExecutedProcessStack = new Stack<ChangedValueInfo>();

        public void Config(BeSafeConfig config, bool stoppingService)
        {
            bool stateResult;

            if ((config?.ComponentsState.RegistryWatcher == true) && (stoppingService == false))
            {
                string userSID = config.UserSID;

                registryWatcher = new RegistryWatcher(new List<RegistryMonitorPath>
                {
                    // CurrentUser keys
                    new RegistryMonitorPath{RegistryHive = RegistryHive.Users, RegistryKeyPath = $@"{userSID}\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.Users, RegistryKeyPath = $@"{userSID}\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.Users, RegistryKeyPath = $@"{userSID}\Software\Microsoft\Windows\CurrentVersion\RunServices"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.Users, RegistryKeyPath = $@"{userSID}\Software\Microsoft\Windows\CurrentVersion\Run"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.Users, RegistryKeyPath = $@"{userSID}\Software\Microsoft\Windows\CurrentVersion\RunOnce"},

                    // LocalMachine keys
                    new RegistryMonitorPath{RegistryHive = RegistryHive.LocalMachine, RegistryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\explorer\Shell Folders"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.LocalMachine, RegistryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\explorer\User Shell Folders"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.LocalMachine, RegistryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\RunServices"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.LocalMachine, RegistryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\RunServicesOnce"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.LocalMachine, RegistryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Run"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.LocalMachine, RegistryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\RunOnce"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.LocalMachine, RegistryKeyPath = @"SOFTWARE\Classes\cplfile\shell\cplopen\command"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.LocalMachine, RegistryKeyPath = @"SOFTWARE\Classes\batfile\shell\open\command"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.LocalMachine, RegistryKeyPath = @"Software\CLASSES\comfile\shell\open\command"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.LocalMachine, RegistryKeyPath = @"Software\CLASSES\exefile\shell\open\command"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.LocalMachine, RegistryKeyPath = @"Software\CLASSES\htafile\Shell\Open\Command"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.LocalMachine, RegistryKeyPath = @"Software\CLASSES\piffile\shell\open\command"},
                    new RegistryMonitorPath{RegistryHive = RegistryHive.LocalMachine, RegistryKeyPath = @"SOFTWARE\Classes\scrfile\shell\open\command"},
                });

                registryWatcher.ValueChanged += ValueChangedArrived;
                stateResult = registryWatcher.Start();

                return;
            }

            stateResult = registryWatcher != null ? registryWatcher.Stop() : false;
        }

        private void ValueChangedArrived(ChangedValueInfo valueInfo)
        {
            ExecutedProcessStack.Push(valueInfo);
            Debug.WriteLine(valueInfo.ToString());
        }
    }
}