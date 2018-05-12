using System;
using System.Windows.Forms;
using ClientUI.Core;
using ClientUI.Core.PluginManager;
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
            PluginManager.LoadPluginsInfoToListBox(lbPlugins);
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

        private void btnLoadPlugin_Click(object sender, EventArgs e)
        {
            if (openPluginFileDialog.ShowDialog() != DialogResult.OK)
                return;

            LoadPluginResult loadResult = PluginManager.LoadPlugin(openPluginFileDialog.FileName);

        }

        private void btnUnloadPlugin_Click(object sender, EventArgs e)
        {
            PluginInfo selectedPlugin = (PluginInfo)lbPlugins.SelectedItem;

            bool unloadResult = PluginManager.UnloadPlugin(selectedPlugin);
            if (unloadResult)
                PluginManager.LoadPluginsInfoToListBox(lbPlugins);
        }
    }
}