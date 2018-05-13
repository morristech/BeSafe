using ConfigManager;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    public class ComponentRegulator
    {
        public static void ManageComponentsState(BeSafeConfig configuration)
        {
            ProcessRegulator.Instance().Config(configuration);
            ModuleRegulator.Instance().Config(configuration);
            SecureVolumeRegulator.Instance().Config(configuration);
        }
    }
}