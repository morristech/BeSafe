using BeSafe.Initializer;
using BeSafe.Initializer.VirtualDrive;

namespace BeSafe.ComponentsConfigurator
{
    public class SecureVolumeConfigurator : IConfigurator
    {
        #region Singleton
        private static SecureVolumeConfigurator SingletonInstance;
        public static SecureVolumeConfigurator Instance() => (SingletonInstance ?? (SingletonInstance = new SecureVolumeConfigurator()));
        #endregion

        private VirtualDrive secureDrive = new VirtualDrive();
        private string _mappedDriveLetter;
        private DriveView driveView;

        public void Config(bool enableState)
        {
            if (enableState)
            {
                _mappedDriveLetter = secureDrive.MapDrive(@"H:\BeSafe");

                driveView = new DriveView(_mappedDriveLetter);
                driveView.SetDriveIcon($"{System.Reflection.Assembly.GetEntryAssembly().Location}");
            }
            else
            {
                secureDrive.UnmapDrive(_mappedDriveLetter);
                driveView.RemoveDriveView();
            }
        }
    }
}