using Common.PipeCommandStructure;

namespace BeSafe.ComponentsConfigurator
{
    public class ConfigManager
    {
        public static void ManageComponentsState(ComponentsEnableState enableState)
        {
            SecureVolumeConfigurator.Instance().Config(enableState.SecureVolume);
        }
    }
}