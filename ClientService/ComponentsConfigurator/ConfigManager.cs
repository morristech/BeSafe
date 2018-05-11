using Common.PipeCommandStructure;

namespace BeSafe.ComponentsConfigurator
{
    public class ConfigManager
    {
        public static void ManageComponentsState(ComponentsEnableState enableState)
        {
            ProcessConfigurator.Instance().Config(enableState.ProcessWatcher);
            SecureVolumeConfigurator.Instance().Config(enableState.SecureVolume);
        }
    }
}