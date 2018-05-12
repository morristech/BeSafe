using BeSafe.Core.Regulators.ComponentRegulators;
using ConfigManager;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    public class ComponentRegulator
    {
        public static void ManageComponentsState(ComponentsEnableState enableState)
        {
            ProcessRegulator.Instance().Config(enableState.ProcessWatcher);
            ModuleRegulator.Instance().Config(enableState.ModuleWatcher);
            SecureVolumeRegulator.Instance().Config(enableState.SecureVolume);
        }
    }
}