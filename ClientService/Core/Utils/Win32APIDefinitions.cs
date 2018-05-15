using System;
using System.Text;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace BeSafe.Core.Utils
{
    public class Win32APIDefinitions
    {
        [DllImport("kernel32", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileTime(SafeFileHandle hFile, ref long lpCreationTime, ref long lpLastAccessTime, ref long lpLastWriteTime);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int QueryDosDevice(string deviceName, StringBuilder buffer, int bufSize);

        #region RegistryWatcher APIs
        public const int KEY_QUERY_VALUE = 0x0001;
        public const int KEY_NOTIFY = 0x0010;
        public const int STANDARD_RIGHTS_READ = 0x00020000;

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern int RegOpenKeyEx(IntPtr hKey, string subKey, uint options, int samDesired,
                                           out IntPtr phkResult);

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern int RegNotifyChangeKeyValue(IntPtr hKey, bool bWatchSubtree,
                                                          int dwNotifyFilter, SafeWaitHandle hEvent,
                                                          bool fAsynchronous);

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern int RegCloseKey(IntPtr hKey);
        #endregion
    }
}