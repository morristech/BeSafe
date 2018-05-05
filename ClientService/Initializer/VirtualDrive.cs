using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace BeSafe.Initializer
{
    public class VirtualDrive
    {
        #region Win32 API declarations
        private const int Undocumented_Shit = 0;
        private const int DDD_REMOVE_DEFINITION = 2;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool DefineDosDevice(int flags, string devname, string path);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int QueryDosDevice(string deviceName, StringBuilder buffer, int bufSize);
        #endregion

        public string SingletonMapDrive(string virtualPath)
        {
            if (string.IsNullOrEmpty(virtualPath))
                return null;

            string[] driveList = Directory.GetLogicalDrives();
            foreach (string drive in driveList)
            {
                string driveMapPath = GetDriveMappingPath(drive);
                if (driveMapPath == virtualPath)
                    return drive;
            }

            return MapDrive(virtualPath);
        }

        public bool UnmapDrive(string driveLetter)
        {
            if (string.IsNullOrEmpty(driveLetter))
                return false;

            driveLetter = NormalizeDriveLetter(driveLetter);

            bool defineDosDeviceResult = DefineDosDevice(DDD_REMOVE_DEFINITION, driveLetter, null);

            if (!defineDosDeviceResult)
                return false;

            // Doubl check drive letter for any mapped item, if any iteme exists, recursively call it self until unmap all mapped drives
            string driveMapPath = GetDriveMappingPath(driveLetter);
            if (!string.IsNullOrEmpty(driveMapPath))
                UnmapDrive(driveLetter);

            return true;
        }

        private string MapDrive(string virtualPath)
        {
            if (!Directory.Exists(virtualPath))
                return null;

            // If user pass null choose first free drive letter
            string[] driveList = Directory.GetLogicalDrives();
            char latestDriveLetter = driveList.LastOrDefault()[0];
            char driveLetter = (char)(latestDriveLetter + 1);


            string normalizedDriveLetter = NormalizeDriveLetter(driveLetter.ToString());
            bool defineDosDeviceResult = DefineDosDevice(Undocumented_Shit, normalizedDriveLetter, virtualPath);

            if (!defineDosDeviceResult)
                return null;

            return normalizedDriveLetter;
        }

        private string GetDriveMappingPath(string driveLetter)
        {
            string normalizedDriveLetter = NormalizeDriveLetter(driveLetter);

            var sb = new StringBuilder(259);

            // Return empty if any error occured
            if (QueryDosDevice(normalizedDriveLetter, sb, sb.Capacity) == 0)
                return string.Empty;

            return sb.ToString().Replace(Properties.Resources.DriveMapMustEscapeChars, string.Empty);
        }

        private string NormalizeDriveLetter(string driveLetter)
        {
            driveLetter = driveLetter.Replace(Path.DirectorySeparatorChar.ToString(), string.Empty);

            if (!driveLetter.EndsWith(Path.VolumeSeparatorChar.ToString()))
                driveLetter = driveLetter.ToUpper() + Path.VolumeSeparatorChar;

            return driveLetter;
        }
    }
}