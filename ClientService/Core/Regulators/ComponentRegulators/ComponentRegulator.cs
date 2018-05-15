using ConfigManager;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    public class ComponentRegulator
    {
        public static void ManageComponentsState(BeSafeConfig configuration, bool stoppingService)
        {
            ProcessRegulator.Instance().Config(configuration, stoppingService);
            ModuleRegulator.Instance().Config(configuration, stoppingService);
            RegistryRegulator.Instance().Config(configuration, stoppingService);
            SecureVolumeRegulator.Instance().Config(configuration, stoppingService);
        }
    }
}