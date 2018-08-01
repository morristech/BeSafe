﻿using System;
using System.Collections.Generic;
using System.Linq;
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

            ConfigLoader.LoadConfigToUI(this);

            // Load plugins to UI
            PluginManager.LoadPluginsInfoToListBox(lbPlugins);
        }

        private void OnServerCommandReceived(NamedPipeConnection<BeSafePipeCommand, BeSafePipeCommand> connection,
            BeSafePipeCommand command)
        {
            switch (command.Command)
            {
                case PipeCommands.Notification:
                    MessageBox.Show(command.Notification, string.Empty, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;

                case PipeCommands.PluginScanResult:
                {
                    PluginResult pResult = command.PluginScanResult;

                    notifyIcon.Tag = pResult;
                    ToolTipIcon icon = command.PluginScanResult.RiskRate == ThreatRiskRates.HighRisk
                        ? ToolTipIcon.Error
                        : ToolTipIcon.Warning;
                    string message = $"{pResult.PluginInfo.Name}{Environment.NewLine}{pResult.Message}";
                    notifyIcon.ShowBalloonTip(3000, Resources.ApplicationName, message, icon);
                }
                    break;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Save setting to config file
            ConfigLoader.LoadConfigToFile(this);

            bool sendCommandResult = pipeClient.SendCommandToService(new BeSafePipeCommand
            {
                CommandId = Guid.NewGuid(),
                Command = PipeCommands.ComponentConfiguration,
            });

            this.Hide();
        }

        private void btnLoadPlugin_Click(object sender, EventArgs e)
        {
            if (openPluginFileDialog.ShowDialog() != DialogResult.OK)
                return;

            LoadPluginResult loadResult = PluginManager.LoadPlugin(openPluginFileDialog.FileName);

            switch (loadResult)
            {
                case LoadPluginResult.Success:
                    PluginManager.LoadPluginsInfoToListBox(lbPlugins);
                    break;

                case LoadPluginResult.Failed:
                    MessageBox.Show(Resources.FailedToLoadPlugin, string.Empty, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;

                case LoadPluginResult.AlreadyExists:
                    MessageBox.Show(Resources.PluginAlreadyExists, string.Empty, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
            }
        }

        private void btnUnloadPlugin_Click(object sender, EventArgs e)
        {
            PluginInfo selectedPlugin = (PluginInfo) lbPlugins.SelectedItem;

            bool unloadResult = PluginManager.UnloadPlugin(selectedPlugin);
            if (unloadResult)
                PluginManager.LoadPluginsInfoToListBox(lbPlugins);
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            NotifyIcon ni = (NotifyIcon) sender;

            if (ni.Tag is PluginResult)
            {
                PluginResult pResult = (PluginResult) ni.Tag;

                ThreatInfo.Execute(pResult);
            }
        }

        #region UI minimize and restore

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
            bool confirmExit = MessageBox.Show(Resources.ConfirmExitMessage, string.Empty, MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) == DialogResult.Yes;
            if (confirmExit)
            {
                pipeClient.Stop();
                this.CanClose = true;
                this.Close();
            }
        }

        #endregion

        private void logHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogHistory.Execute();
        }

        private void btnAddFileExtension_Click(object sender, EventArgs e)
        {
            string userEnteredExtension = AddExtension.Execute();

            if ((string.IsNullOrEmpty(userEnteredExtension)) || (!ValidateExtension(userEnteredExtension)))
                return;

            List<string> tempExtensions = lbProtectionExtensions.Items.Cast<string>().ToList();

            bool extensionAlreadyExists = tempExtensions.FirstOrDefault(f => f == userEnteredExtension) != null;
            if (extensionAlreadyExists)
                return;

            tempExtensions.Add(userEnteredExtension);
            lbProtectionExtensions.DataSource = tempExtensions;
        }

        private void btnRemoveFileExtension_Click(object sender, EventArgs e)
        {
            if (lbProtectionExtensions.SelectedIndex == -1)
                return;

            List<string> tempExtensions = lbProtectionExtensions.Items.Cast<string>().ToList();
            tempExtensions.RemoveAt(lbProtectionExtensions.SelectedIndex);

            lbProtectionExtensions.DataSource = tempExtensions;
        }

        private bool ValidateExtension(string extension)
        {
            return extension.StartsWith(".");
        }
    }
}