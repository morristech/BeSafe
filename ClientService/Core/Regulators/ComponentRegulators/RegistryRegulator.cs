using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Win32;
using ConfigManager;
using BeSafe.Components.Watchers;
using BeSafe.Components.Watchers.Types.RegistryWatcherTypes;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    public class RegistryRegulator : IRegulator
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
                registryWatcher = new RegistryWatcher(new List<RegistryMonitorPath>
                {
                    new RegistryMonitorPath()
                });

                registryWatcher.ValueChanged += ValueChangedArrived;
                stateResult = registryWatcher.Start();

                return;
            }

            stateResult = registryWatcher.Stop();
        }

        private void ValueChangedArrived(ChangedValueInfo valueInfo)
        {
            ExecutedProcessStack.Push(valueInfo);
            Debug.WriteLine(valueInfo.ToString());
        }
    }
}