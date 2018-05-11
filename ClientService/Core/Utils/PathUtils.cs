using BeSafe.Properties;
using System;
using System.IO;

namespace BeSafe.Core.Utils
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
    }
}