using ConfigManager;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    interface IComponentRegulator
    {
        void Config(BeSafeConfig config, bool stoppingService);
    }
}