using System.Diagnostics;
using System.Collections.Generic;
using BeSafe.Components.Watchers;
using BeSafe.Components.Watchers.Types;
using ConfigManager;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    public class ModuleRegulator : IComponentRegulator
    {
        #region Singleton
        private static ModuleRegulator SingletonInstance;
        public static ModuleRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new ModuleRegulator()));
        #endregion    

        private ModuleWatcher moduleWatcher = new ModuleWatcher();
        private Stack<ModuleInfo> LoadedModulesStack = new Stack<ModuleInfo>();

        public ModuleRegulator()
        {
            moduleWatcher.LoadModule += OnLoadModule;
        }
        public void Config(BeSafeConfig config, bool stoppingService)
        {
            bool stateResult = (((config?.ComponentsState.ModuleWatcher == true) && (stoppingService == false)) 
                ? moduleWatcher.Start() 
                : moduleWatcher.Stop());
        }

        private void OnLoadModule(ModuleInfo moduleInfo)
        {
            // TODO Scan engines not implemented yet, after they get ready use theme to scan process here :)
            LoadedModulesStack.Push(moduleInfo);
            Debug.WriteLine(moduleInfo.ToString());
        }
    }
}