using System;
using System.IO;
using Common.Properties;

namespace Common.Utils
{
    public class PathUtils
    {
        public static string BeSafePath
        {
            get
            {
                string appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string beSafePath = Path.Combine(appdataPath, Resources.ApplicationName);

                if (!Directory.Exists(beSafePath))
                    Directory.CreateDirectory(beSafePath);

                return beSafePath;
            }
        }

        public static string BeSafeSecureVolumePath
        {
            get
            {
                string myDocumentspath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string beSafeSecureVolumePath = Path.Combine(myDocumentspath, Resources.ApplicationName);

                if (!Directory.Exists(beSafeSecureVolumePath))
                    Directory.CreateDirectory(beSafeSecureVolumePath);

                return beSafeSecureVolumePath;
            }
        }

        public static string PluginsPath
        {
            get
            {
                string beSafePluginsPath = Path.Combine(BeSafePath, Resources.PluginsPathName);

                if (!Directory.Exists(beSafePluginsPath))
                    Directory.CreateDirectory(beSafePluginsPath);

                return beSafePluginsPath;
            }
        }

        public static string ConfigFilePath
        {
            get
            {
                string beSafeConfigFilePath = Path.Combine(BeSafePath, Resources.ConfigFileName);

                return beSafeConfigFilePath;
            }
        }
    }
}