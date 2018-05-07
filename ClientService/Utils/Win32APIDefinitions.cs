using System.Text;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace BeSafe.Utils
{
    public class Win32APIDefinitions
    {
        [DllImport("kernel32", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetFileTime(SafeFileHandle hFile, ref long lpCreationTime, ref long lpLastAccessTime, ref long lpLastWriteTime);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int QueryDosDevice(string deviceName, StringBuilder buffer, int bufSize);
    }
}