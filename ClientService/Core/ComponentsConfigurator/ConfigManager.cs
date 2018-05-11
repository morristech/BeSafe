using Common.PipeCommandStructure;

namespace BeSafe.Core.ComponentsConfigurator
{
    public class ConfigManager
    {
        public static void ManageComponentsState(ComponentsEnableState enableState)
        {
            ProcessConfigurator.Instance().Config(enableState.ProcessWatcher);
            ModuleConfigurator.Instance().Config(enableState.ModuleWatcher);
            SecureVolumeConfigurator.Instance().Config(enableState.SecureVolume);
        }
    }
}