using System.Diagnostics;
using System.Collections.Generic;
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

        public RegistryRegulator()
        {
            registryWatcher = new RegistryWatcher(new List<RegistryMonitorPath>());
            registryWatcher.ValueChanged += ValueChangedArrived;
        }

        public void Config(BeSafeConfig config, bool stoppingService)
        {
            bool stateResult =
                (((config?.ComponentsState.RegistryWatcher == true) && (stoppingService == false))
                ? registryWatcher.Start()
                : registryWatcher.Stop());
        }
        private void ValueChangedArrived(ChangedValueInfo valueInfo)
        {
            ExecutedProcessStack.Push(valueInfo);
            Debug.WriteLine(valueInfo.ToString());
        }
    }
}