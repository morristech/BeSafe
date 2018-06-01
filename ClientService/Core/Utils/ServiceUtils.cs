using System;
using System.IO;
using System.Linq;
using BeSafe.Properties;
using ExceptionManager;

namespace BeSafe.Core.Utils
{
    public static class ServiceUtils
    {
        public static DriveInfo GetBeSafeDriveLetter()
        {
            return DriveInfo.GetDrives().FirstOrDefault(d => d.DriveFormat == Resources.SecureVolumeFileSystem);
        }

        public static bool SystemHiddenDirectory(string direcotry)
        {
            try
            {
                DirectoryInfo secureVolumeMappedPathInfo = new DirectoryInfo(direcotry);
                secureVolumeMappedPathInfo.Attributes = FileAttributes.Directory | FileAttributes.Hidden | FileAttributes.System;
                return true;
            }
            catch (Exception ex)
            {
                ex.Log();
                return false;
            }
        }
    }
}