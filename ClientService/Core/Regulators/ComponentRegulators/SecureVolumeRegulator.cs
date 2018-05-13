using BeSafe.Components.Initializers;
using BeSafe.Components.Initializers.VirtualDrive;
using ConfigManager;

namespace BeSafe.Core.Regulators.ComponentRegulators
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

        public void Config(BeSafeConfig config)
        {
            if (config.ComponentsState.SecureVolume)
            {
                _mappedDriveLetter = secureDrive.MapDrive(config.SecureVolumePath);

                driveView = new DriveView(_mappedDriveLetter);
                driveView.SetDriveIcon($"{System.Reflection.Assembly.GetEntryAssembly().Location}");
            }
            else
            {
                if (string.IsNullOrEmpty(_mappedDriveLetter))
                    return;

                secureDrive.UnmapDrive(_mappedDriveLetter);
                driveView.RemoveDriveView();
            }
        }
    }
}