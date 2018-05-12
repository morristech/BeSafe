using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ClientUI.Core;
using ClientUI.Core.Utils;
using ClientUI.Properties;
using Common.PipeCommandStructure;
using NamedPipeWrapper;
using PluginSDK;

namespace ClientUI
{
    public partial class Setting : Form
    {
        private readonly PipeClient pipeClient = new PipeClient();
        private bool CanClose = false;

        public Setting()
        {
            InitializeComponent();

            pipeClient.ServerMessageEventHandler += OnServerCommandReceived;
            pipeClient.Start();

            // Load plugins to UI
            List<IBeSafePlugin> plugins = new PluginUtils().GetPluginsInfo(PathUtils.PluginsPath);
            foreach (IBeSafePlugin plugin in plugins)
                lbPlugins.Items.Add(plugin.GetPluginInfo());
        }

        private void OnServerCommandReceived(NamedPipeConnection<BeSafePipeCommand, BeSafePipeCommand> connection, BeSafePipeCommand command)
        {
            MessageBox.Show(command.Notification);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ComponentsEnableState enableState = new ComponentsEnableState
            {
                DynamicScanEngine = chbDynamicEngine.Checked,
                ModuleWatcher = chbmoduleWatcher.Checked,
                ProcessWatcher = chbProcessWatcher.Checked,
                SecureVolume = chbSecureVolume.Checked,
                StaticScanEngine = chbStaticEngine.Checked,
                VirusTotalEngine = chbVirusTotalEngine.Checked,
                YaraEngine = chbYaraEngine.Checked,
                ProtectorDetectorEngine = chbProtectorDetector.Checked,
            };

            bool sendCommandResult = pipeClient.SendCommandToService(new BeSafePipeCommand
            {
                CommandId = Guid.NewGuid(),
                Command = PipeCommands.ComponentConfiguration,
                ComponentsState = enableState,
            });
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CanClose;
            this.Hide();
        }

        private void Setting_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Close();
        }
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool confirmExit = MessageBox.Show(Resources.ConfirmExitMessage, string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            if (confirmExit)
            {
                pipeClient.Stop();
                this.CanClose = true;
                this.Close();
            }
        }
    }
}