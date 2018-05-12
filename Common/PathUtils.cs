using System;
using System.IO;
using Common.Properties;

namespace Common
{
    public class PathUtils
    {
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