using System;
using System.Windows.Forms;
using ClientUI.Core;
using Common.PipeCommandStructure;
using NamedPipeWrapper;

namespace ClientUI
{
    public partial class Setting : Form
    {
        private readonly PipeClient pipeClient = new PipeClient();

        public Setting()
        {
            InitializeComponent();

            pipeClient.ServerMessageEventHandler += OnServerCommandReceived;
            pipeClient.Start();
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
    }
}