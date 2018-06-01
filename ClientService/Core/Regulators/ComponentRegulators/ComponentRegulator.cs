using BeSafe.Core.Utils;
using ConfigManager;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    public class ComponentRegulator
    {
        public static void ManageComponentsState(BeSafeConfig configuration, PipeServer pipeServer, bool stoppingService)
        {
            ProcessRegulator.Instance().Config(configuration, pipeServer, stoppingService);
            ModuleRegulator.Instance().Config(configuration, pipeServer, stoppingService);
            DirectoryRegulator.Instance().Config(configuration, pipeServer, stoppingService);
            RegistryRegulator.Instance().Config(configuration, pipeServer, stoppingService);
            SecureVolumeRegulator.Instance().Config(configuration, pipeServer, stoppingService);
        }
    }
}