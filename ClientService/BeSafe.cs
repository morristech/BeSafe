using BeSafe.Properties;
using BeSafe.Initializer;
using System.ServiceProcess;
using BeSafe.Utils;
using ExceptionManager;

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
    }
}