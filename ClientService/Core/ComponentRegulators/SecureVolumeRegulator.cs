using BeSafe.Components.Initializers;
using BeSafe.Components.Initializers.VirtualDrive;

namespace BeSafe.Core.ComponentRegulators
{
    public class SecureVolumeRegulator : IRegulator
    {
        #region Singleton
        private static SecureVolumeRegulator SingletonInstance;
        public static SecureVolumeRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new SecureVolumeRegulator()));
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