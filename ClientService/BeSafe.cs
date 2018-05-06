using BeSafe.Properties;
using BeSafe.Initializer;
using System.ServiceProcess;
using BeSafe.Utils;
using ExceptionManager;
using Common;

namespace ClientService
{
    public partial class BeSafe : ServiceBase
    {
        private VirtualDrive _virtualDrive;
        private DriveView _driveView;
        private string _besafeSecureVolumeLetter;

        public BeSafe()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                _virtualDrive = new VirtualDrive();
                _besafeSecureVolumeLetter = _virtualDrive.SingletonMapDrive(PathUtils.BeSafeSecureVolumePath);
                _driveView = new DriveView(_besafeSecureVolumeLetter);

                bool setDriveIconResult = _driveView.SetDriveIcon(_besafeSecureVolumeLetter);
                bool setDriveLabelResult = _driveView.SetDriveLabel(Resources.ApplicationName);
            }
            catch (System.Exception ex)
            {
                ex.Log();
            }
        }

        protected override void OnStop()
        {
            _virtualDrive.UnmapDrive(_besafeSecureVolumeLetter);
            _driveView.RemoveDriveView();
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