using System.Diagnostics;
using System.Collections.Generic;
using BeSafe.Watchers;
using BeSafe.Watchers.Types;

namespace BeSafe.ComponentsConfigurator
{
    public class ModuleConfigurator : IConfigurator
    {
        #region Singleton
        private static ModuleConfigurator SingletonInstance;
        public static ModuleConfigurator Instance() => (SingletonInstance ?? (SingletonInstance = new ModuleConfigurator()));
        #endregion    

        private ModuleWatcher moduleWatcher = new ModuleWatcher();
        private Stack<ModuleInfo> LoadedModulesStack = new Stack<ModuleInfo>();

        public ModuleConfigurator()
        {
            moduleWatcher.LoadModule += OnLoadModule;
        }
        public void Config(bool enableState)
        {
            bool stateResult = (enableState == true ? moduleWatcher.Start() : moduleWatcher.Stop());
        }

        private void OnLoadModule(ModuleInfo moduleInfo)
        {
            // TODO Scan engines not implemented yet, after they get ready use theme to scan process here :)
            LoadedModulesStack.Push(moduleInfo);
            Debug.WriteLine(moduleInfo.ToString());
        }
    }
}