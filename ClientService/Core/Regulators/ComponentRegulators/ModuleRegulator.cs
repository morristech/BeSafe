using System.Diagnostics;
using System.Collections.Generic;
using BeSafe.Components.Watchers;
using ConfigManager;
using BeSafe.Core.Utils;
using SharedTypes.Watchers;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    public class ModuleRegulator : IComponentRegulator
    {
        #region Singleton
        private static ModuleRegulator SingletonInstance;
        public static ModuleRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new ModuleRegulator()));
        #endregion    

        private readonly ModuleWatcher _moduleWatcher = new ModuleWatcher();
        private readonly Queue<ModuleInfo> _loadedModulesStack = new Queue<ModuleInfo>();

        private ModuleRegulator()
        {
            _moduleWatcher.LoadModule += OnLoadModule;
        }

        public void Config(BeSafeConfig config, PipeServer pipeServer, bool stoppingService)
        {
            bool stateResult = (((config?.ComponentsState.ModuleWatcher == true) && (stoppingService == false)) 
                ? _moduleWatcher.Start() 
                : _moduleWatcher.Stop());
        }

        private void OnLoadModule(ModuleInfo moduleInfo)
        {
            // TODO Scan engines not implemented yet, after they get ready use theme to scan process here :)
            _loadedModulesStack.Enqueue(moduleInfo);
            Debug.WriteLine(moduleInfo.ToString());
        }
    }
}