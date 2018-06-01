using Common.Utils;
using ConfigManager;

namespace ClientUI.Core
{
    public class ConfigLoader
    {
        public static bool LoadConfigToUI(Setting settingForm)
        {
            BeSafeConfig beSafeConfig = new BeSafeConfig(PathUtils.ConfigFilePath);

            bool loadConfigResult = beSafeConfig.Load();
            if (!loadConfigResult)
                return false;

            settingForm.chbProcessWatcher.Checked = beSafeConfig.ComponentsState.ProcessWatcher;
            settingForm.chbmoduleWatcher.Checked = beSafeConfig.ComponentsState.ModuleWatcher;
            settingForm.chbDirectoryWatcher.Checked = beSafeConfig.ComponentsState.DirectoryWatcher;
            settingForm.chbRegistryWatcher.Checked = beSafeConfig.ComponentsState.RegistryWatcher;
            settingForm.chbYaraEngine.Checked = beSafeConfig.ComponentsState.YaraEngine;
            settingForm.chbSecureVolume.Checked = beSafeConfig.ComponentsState.SecureVolume;
            settingForm.chbStaticEngine.Checked = beSafeConfig.ComponentsState.StaticScanEngine;
            settingForm.chbDynamicEngine.Checked = beSafeConfig.ComponentsState.DynamicScanEngine;
            settingForm.chbFightWithThreats.Checked = beSafeConfig.ComponentsState.FightWithThreats;
            settingForm.chbVirusTotalEngine.Checked = beSafeConfig.ComponentsState.VirusTotalEngine;

            return true;
        }

        public static bool LoadConfigToFile(Setting settingForm)
        {
            BeSafeConfig beSafeConfig = new BeSafeConfig(PathUtils.ConfigFilePath);

            bool loadConfigResult = beSafeConfig.Load();
            if (!loadConfigResult)
                return false;

            beSafeConfig.ComponentsState.ProcessWatcher = settingForm.chbProcessWatcher.Checked;
            beSafeConfig.ComponentsState.ModuleWatcher = settingForm.chbmoduleWatcher.Checked;
            beSafeConfig.ComponentsState.DirectoryWatcher = settingForm.chbDirectoryWatcher.Checked;
            beSafeConfig.ComponentsState.RegistryWatcher = settingForm.chbRegistryWatcher.Checked;
            beSafeConfig.ComponentsState.YaraEngine = settingForm.chbYaraEngine.Checked;
            beSafeConfig.ComponentsState.SecureVolume = settingForm.chbSecureVolume.Checked;
            beSafeConfig.ComponentsState.StaticScanEngine = settingForm.chbStaticEngine.Checked;
            beSafeConfig.ComponentsState.DynamicScanEngine = settingForm.chbDynamicEngine.Checked;
            beSafeConfig.ComponentsState.FightWithThreats = settingForm.chbFightWithThreats.Checked;
            beSafeConfig.ComponentsState.VirusTotalEngine = settingForm.chbVirusTotalEngine.Checked;

            beSafeConfig.Save();

            return true;
        }
    }
}