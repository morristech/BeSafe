using Common.PipeCommandStructure;

namespace BeSafe.ComponentsConfigurator
{
    public class ConfigManager
    {
        public static void Manage(ComponentsEnableState enableState)
        {
            SecureVolumeConfigurator.Instance().Config(enableState.SecureVolume);
        }
    }
}