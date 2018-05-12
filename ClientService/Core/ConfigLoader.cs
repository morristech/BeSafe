using System.IO;
using ConfigManager;

namespace BeSafe.Core
{
    public class ConfigLoader
    {
        #region Singleton
        private static ConfigLoader SingletonInstance;
        public static ConfigLoader Instance() => (SingletonInstance ?? (SingletonInstance = new ConfigLoader()));

        private BeSafeConfig _beSafeConfig;
        #endregion    

        public BeSafeConfig LoadConfig()
        {
            if (_beSafeConfig == null)
            {
                string settingFilePath = new ServiceSetting().RetriveConfigFilePath();

                if (!File.Exists(settingFilePath))
                    return null;

                _beSafeConfig = new BeSafeConfig(settingFilePath);
            }

            _beSafeConfig.Load();

            return _beSafeConfig;
        }
    }
}