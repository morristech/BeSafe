using BeSafe.Core.Utils;
using ConfigManager;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    interface IComponentRegulator
    {
        void Config(BeSafeConfig config, PipeServer pipeServer, bool stoppingService);
    }
}