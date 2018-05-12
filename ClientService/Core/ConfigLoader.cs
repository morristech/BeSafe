using System.IO;
using ConfigManager;

namespace BeSafe.Core
{
    public class ConfigLoader
    {
        #region Singleton
        private static ConfigLoader SingletonInstance;
        public static ConfigLoader Instance() => (SingletonInstance ?? (SingletonInstance = new ConfigLoader()));
        #endregion    

        public BeSafeConfig LoadConfig()
        {
            string settingFilePath = new ServiceSetting().RetriveConfigFilePath();

            if (!File.Exists(settingFilePath))
                return null;

            BeSafeConfig config = new BeSafeConfig(settingFilePath);
            config.Load();

            return config;
        }
    }
}