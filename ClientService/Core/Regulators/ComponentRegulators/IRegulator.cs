using ConfigManager;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    interface IRegulator
    {
        void Config(BeSafeConfig config, bool stoppingService);
    }
}