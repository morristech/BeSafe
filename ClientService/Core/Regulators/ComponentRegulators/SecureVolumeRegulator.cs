using BeSafe.Components.Initializers;
using BeSafe.Components.Initializers.VirtualDrive;
using BeSafe.Core.Utils;
using ConfigManager;
using System.IO;

namespace BeSafe.Core.Regulators.ComponentRegulators
{
    public class SecureVolumeRegulator : IComponentRegulator
    {
        #region Singleton
        private static SecureVolumeRegulator SingletonInstance;
        public static SecureVolumeRegulator Instance() => (SingletonInstance ?? (SingletonInstance = new SecureVolumeRegulator()));
        #endregion

        private VirtualDrive secureDrive = new VirtualDrive();
        private DriveView driveView;

        public void Config(BeSafeConfig config, PipeServer pipeServer, bool stoppingService)
        {
            if ((config != null) && (config.ComponentsState.SecureVolume) && (stoppingService == false))
            {
                string mappedDriveLetter = secureDrive.MapDrive(config.SecureVolumePath);

                driveView = new DriveView(mappedDriveLetter);
                driveView.SetDriveIcon($"{System.Reflection.Assembly.GetEntryAssembly().Location}");
            }
            else
            {
                DriveInfo beSafeDriveInfo = ServiceUtils.GetBeSafeDriveLetter();
                if (beSafeDriveInfo == null)
                    return;

                secureDrive.UnmapDrive(beSafeDriveInfo.Name);
                new DriveView(beSafeDriveInfo.Name).RemoveDriveView();
            }
        }
    }
}