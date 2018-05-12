using System;
using System.IO;
using ClientUI.Properties;

namespace ClientUI.Core.Utils
{
    public class PathUtils
    {
        public static string PluginsPath
        {
            get
            {
                string appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string beSafePath = Path.Combine(appdataPath, Resources.ApplicationName);
                string beSafePluginsPath = Path.Combine(beSafePath, Resources.PluginsPathName);

                if (!Directory.Exists(beSafePluginsPath))
                    Directory.CreateDirectory(beSafePluginsPath);

                return beSafePluginsPath;
            }
        }
    }
}