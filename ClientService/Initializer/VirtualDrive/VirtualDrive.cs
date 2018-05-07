using System;
using System.IO;
using System.Linq;
using System.Text;
using BeSafe.Utils;
using BeSafe.Properties;
using ExceptionManager;
using DokanNet;

namespace BeSafe.Initializer.VirtualDrive
{
    public class VirtualDrive : IVirtualDrive
    {
        private BeSafeFileSystemImpl virtualDriveImpl;
        private const int NumberOfThradsToManageFileSystem = 5;

        public string MapDrive(string virtualPath)
        {
            if (string.IsNullOrEmpty(virtualPath))
                throw new ArgumentNullException(nameof(virtualPath));

            try
            {
                string unusedDriveLetter = FirstUnusedDriveLetter();
                string normalizedDriveLetter = NormalizeDriveLetter(unusedDriveLetter);

                virtualDriveImpl = new BeSafeFileSystemImpl(virtualPath);
                virtualDriveImpl.Mount(normalizedDriveLetter, DokanOptions.FixedDrive, NumberOfThradsToManageFileSystem);

                return normalizedDriveLetter;
            }
            catch (Exception ex)
            {
                ex.Log(ExceptionType.SecureVolume, "Can not mount virtual drive");
                return null;
            }
        }

        public string GetDriveMappingPath(string driveLetter)
        {
            if (string.IsNullOrEmpty(driveLetter))
                throw new ArgumentNullException(nameof(driveLetter));

            string normalizedDriveLetter = NormalizeDriveLetter(driveLetter);

            // Return empty if any error occured
            var sb = new StringBuilder(259);
            if (Win32APIDefinitions.QueryDosDevice(normalizedDriveLetter, sb, sb.Capacity) == 0)
                return string.Empty;

            return sb.ToString().Replace(Resources.DriveMapMustEscapeChars, string.Empty);
        }

        public bool UnmapDrive(string driveLetter)
        {
            if (string.IsNullOrEmpty(driveLetter))
                throw new ArgumentNullException(nameof(driveLetter));

            try
            {
                Dokan.Unmount(driveLetter[0]);
                return true;
            }
            catch (Exception ex)
            {
                ex.Log(ExceptionType.SecureVolume, @"Can not unmount virtual drive");
                return false;
            }
        }

        private string FirstUnusedDriveLetter()
        {
            string[] driveList = Directory.GetLogicalDrives();
            char latestDriveLetter = driveList.LastOrDefault()[0];
            char driveLetter = (char)(latestDriveLetter + 1);

            return driveLetter.ToString();
        }

        private string NormalizeDriveLetter(string driveLetter)
        {
            if (string.IsNullOrEmpty(driveLetter))
                throw new ArgumentNullException(nameof(driveLetter));

            driveLetter = driveLetter.Replace(Path.DirectorySeparatorChar.ToString(), string.Empty);

            if (!driveLetter.EndsWith(Path.VolumeSeparatorChar.ToString()))
                driveLetter = driveLetter.ToUpper() + Path.VolumeSeparatorChar;

            return driveLetter;
        }
    }
}