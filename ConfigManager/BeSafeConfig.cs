using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;
using Common.Utils;
using ExceptionManager;

namespace ConfigManager
{
    [Serializable]
    public class BeSafeConfig
    {
        private readonly string _configFilePath;

        /// <summary>
        /// Contain SID of current user
        /// </summary>
        public string UserSID { get; set; }

        /// <summary>
        /// Contain SecureVolume map path
        /// </summary>
        public string SecureVolumePath { get; set; }

        /// <summary>
        /// Contain "Plugin" directory path
        /// </summary>
        public string PluginsPath { get; set; }

        /// <summary>
        /// Contain enable state of BeSafe components
        /// </summary>
        public ComponentsEnableState ComponentsState { get; set; }

        public BeSafeConfig(string configFilePath)
        {
            if (string.IsNullOrEmpty(configFilePath))
                throw new ArgumentNullException(nameof(configFilePath));

            _configFilePath = configFilePath;

            Load();
        }

        public bool Load()
        {
            bool createConfigResult = CreateDefaultConfig();
            if (!createConfigResult)
                return false;

            try
            {
                using (var tempStream = new MemoryStream(File.ReadAllBytes(_configFilePath)))
                {
                    BinaryFormatter bformatter = new BinaryFormatter();
                    BeSafeConfig tempConfig = (BeSafeConfig)bformatter.Deserialize(tempStream);

                    // Assign loaded config fields to local fields for use
                    this.UserSID = tempConfig.UserSID;
                    this.SecureVolumePath = tempConfig.SecureVolumePath;
                    this.PluginsPath = tempConfig.PluginsPath;
                    this.ComponentsState = tempConfig.ComponentsState;
                }

                return true;
            }
            catch (Exception ex)
            {
                ex.Log();
                return false;
            }
        }

        /// <summary>
        /// Serialize current config and save to config file
        /// </summary>
        /// <returns>Determine save config process success or not</returns>
        public bool Save()
        {
            try
            {
                using (var tempStream = new MemoryStream())
                {
                    BinaryFormatter bformatter = new BinaryFormatter();
                    bformatter.Serialize(tempStream, this);
                    File.WriteAllBytes(_configFilePath, tempStream.ToArray());
                }

                return true;
            }
            catch (Exception ex)
            {
                ex.Log();
                return false;
            }
        }


        /// <summary>
        /// Fill setting fields with default values and create default setting file 
        /// </summary>
        private bool CreateDefaultConfig()
        {
            // Check if default config exists nothing to do
            if (File.Exists(_configFilePath))
                return true;

            // Initialize default config
            try
            {
                this.UserSID = WindowsIdentity.GetCurrent()?.User?.ToString();
                this.SecureVolumePath = PathUtils.BeSafeSecureVolumePath;
                this.PluginsPath = PathUtils.PluginsPath;
                this.ComponentsState = new ComponentsEnableState();
                
                Save();
                return true;
            }
            catch (Exception ex)
            {
                ex.Log();
                return false;
            }
        }
    }
}