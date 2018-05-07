using System.ServiceProcess;
using Common;
using ExceptionManager;

namespace ClientService
{
    public partial class BeSafe : ServiceBase
    {
        public BeSafe()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                ex.Log();
            }
        }

        protected override void OnStop()
        {

        }

        protected override void OnCustomCommand(int serviceCommand)
        {
            switch (serviceCommand)
            {
                case (int)ServiceCommands.StopProcessWatcher:
                    //
                    break;

                case (int)ServiceCommands.StartProcessWatcher:
                    //
                    break;

                case (int)ServiceCommands.StopModuleWatcher:
                    //
                    break;

                case (int)ServiceCommands.StartModuleWatcher:
                    //
                    break;

                case (int)ServiceCommands.StopYaraEngine:
                    //
                    break;

                case (int)ServiceCommands.StartYaraEngine:
                    //
                    break;

                case (int)ServiceCommands.StopSecureVolume:
                    //
                    break;

                case (int)ServiceCommands.StartSecureVolume:
                    //
                    break;

                case (int)ServiceCommands.StopStaticEngine:
                    //
                    break;

                case (int)ServiceCommands.StartStaticEngine:
                    //
                    break;

                case (int)ServiceCommands.StopDynamicEngine:
                    //
                    break;

                case (int)ServiceCommands.StartDynamicEngine:
                    //
                    break;

                case (int)ServiceCommands.StopVTEngine:
                    //
                    break;

                case (int)ServiceCommands.StartVTEngine:
                    //
                    break;

                default:
                    break;
            }
        }
    }
}