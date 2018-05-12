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
            settingForm.chbYaraEngine.Checked = beSafeConfig.ComponentsState.YaraEngine;
            settingForm.chbSecureVolume.Checked = beSafeConfig.ComponentsState.SecureVolume;
            settingForm.chbStaticEngine.Checked = beSafeConfig.ComponentsState.StaticScanEngine;
            settingForm.chbDynamicEngine.Checked = beSafeConfig.ComponentsState.DynamicScanEngine;
            settingForm.chbKillSuspicious.Checked = beSafeConfig.ComponentsState.AutoKill;
            settingForm.chbQuarantineSuspicious.Checked = beSafeConfig.ComponentsState.AutoQuarantine;
            settingForm.chbVirusTotalEngine.Checked = beSafeConfig.ComponentsState.VirusTotalEngine;
            settingForm.chbProtectorDetector.Checked = beSafeConfig.ComponentsState.ProtectorDetectorEngine;

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
            beSafeConfig.ComponentsState.YaraEngine = settingForm.chbYaraEngine.Checked;
            beSafeConfig.ComponentsState.SecureVolume = settingForm.chbSecureVolume.Checked;
            beSafeConfig.ComponentsState.StaticScanEngine = settingForm.chbStaticEngine.Checked;
            beSafeConfig.ComponentsState.DynamicScanEngine = settingForm.chbDynamicEngine.Checked;
            beSafeConfig.ComponentsState.AutoKill = settingForm.chbKillSuspicious.Checked;
            beSafeConfig.ComponentsState.AutoQuarantine = settingForm.chbQuarantineSuspicious.Checked;
            beSafeConfig.ComponentsState.VirusTotalEngine = settingForm.chbVirusTotalEngine.Checked;
            beSafeConfig.ComponentsState.ProtectorDetectorEngine = settingForm.chbProtectorDetector.Checked;

            beSafeConfig.Save();

            return true;
        }
    }
}