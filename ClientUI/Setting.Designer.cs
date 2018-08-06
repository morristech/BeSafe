namespace ClientUI
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TryIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.monoFlat_ThemeContainer1 = new ClientUI.MonoFlat_ThemeContainer();
            this.monoFlat_ControlBox1 = new ClientUI.MonoFlat_ControlBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.chbDirectoryWatcher = new ClientUI.MonoFlat_CheckBox();
            this.chbRegistryWatcher = new ClientUI.MonoFlat_CheckBox();
            this.chbVirusTotalEngine = new ClientUI.MonoFlat_CheckBox();
            this.chbFightWithThreats = new ClientUI.MonoFlat_CheckBox();
            this.chbDynamicEngine = new ClientUI.MonoFlat_CheckBox();
            this.chbStaticEngine = new ClientUI.MonoFlat_CheckBox();
            this.chbSecureVolume = new ClientUI.MonoFlat_CheckBox();
            this.chbYaraEngine = new ClientUI.MonoFlat_CheckBox();
            this.chbmoduleWatcher = new ClientUI.MonoFlat_CheckBox();
            this.chbProcessWatcher = new ClientUI.MonoFlat_CheckBox();
            this.tpPlugins = new System.Windows.Forms.TabPage();
            this.btnUnloadPlugin = new ClientUI.MonoFlat_Button();
            this.btnLoadPlugin = new ClientUI.MonoFlat_Button();
            this.lbPlugins = new System.Windows.Forms.ListBox();
            this.tpFileProtection = new System.Windows.Forms.TabPage();
            this.btnRemoveFileExtension = new ClientUI.MonoFlat_Button();
            this.btnAddFileExtension = new ClientUI.MonoFlat_Button();
            this.rbtnBlacklist = new ClientUI.MonoFlat_RadioButton();
            this.rbtnWhiteList = new ClientUI.MonoFlat_RadioButton();
            this.lbProtectionExtensions = new System.Windows.Forms.ListBox();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.lbllVTApiKey = new ClientUI.MonoFlat_Label();
            this.tbVTApiKey = new ClientUI.MonoFlat_TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.monoFlat_HeaderLabel1 = new ClientUI.MonoFlat_HeaderLabel();
            this.btnApply = new ClientUI.MonoFlat_Button();
            this.openPluginFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chbUseSystemProxy = new ClientUI.MonoFlat_CheckBox();
            this.TryIconMenu.SuspendLayout();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpConfiguration.SuspendLayout();
            this.tpPlugins.SuspendLayout();
            this.tpFileProtection.SuspendLayout();
            this.tpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // TryIconMenu
            // 
            this.TryIconMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TryIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.logHistoryToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.TryIconMenu.Name = "TryIconMenu";
            this.TryIconMenu.Size = new System.Drawing.Size(136, 92);
            // 
            // logHistoryToolStripMenuItem
            // 
            this.logHistoryToolStripMenuItem.Name = "logHistoryToolStripMenuItem";
            this.logHistoryToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.logHistoryToolStripMenuItem.Text = "Log History";
            this.logHistoryToolStripMenuItem.Click += new System.EventHandler(this.logHistoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "BeSafe";
            this.notifyIcon.ContextMenuStrip = this.TryIconMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "BeSafe";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.tabControl);
            this.monoFlat_ThemeContainer1.Controls.Add(this.Logo);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_HeaderLabel1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnApply);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(578, 427);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.monoFlat_ThemeContainer1.TabIndex = 1;
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(466, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 39;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tpConfiguration);
            this.tabControl.Controls.Add(this.tpPlugins);
            this.tabControl.Controls.Add(this.tpFileProtection);
            this.tabControl.Controls.Add(this.tpAccount);
            this.tabControl.Location = new System.Drawing.Point(15, 73);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(550, 285);
            this.tabControl.TabIndex = 38;
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.tpConfiguration.Controls.Add(this.chbDirectoryWatcher);
            this.tpConfiguration.Controls.Add(this.chbRegistryWatcher);
            this.tpConfiguration.Controls.Add(this.chbVirusTotalEngine);
            this.tpConfiguration.Controls.Add(this.chbFightWithThreats);
            this.tpConfiguration.Controls.Add(this.chbDynamicEngine);
            this.tpConfiguration.Controls.Add(this.chbStaticEngine);
            this.tpConfiguration.Controls.Add(this.chbSecureVolume);
            this.tpConfiguration.Controls.Add(this.chbYaraEngine);
            this.tpConfiguration.Controls.Add(this.chbmoduleWatcher);
            this.tpConfiguration.Controls.Add(this.chbProcessWatcher);
            this.tpConfiguration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpConfiguration.Location = new System.Drawing.Point(4, 27);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguration.Size = new System.Drawing.Size(542, 254);
            this.tpConfiguration.TabIndex = 0;
            this.tpConfiguration.Text = "Configuration";
            // 
            // chbDirectoryWatcher
            // 
            this.chbDirectoryWatcher.Checked = false;
            this.chbDirectoryWatcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbDirectoryWatcher.Location = new System.Drawing.Point(18, 64);
            this.chbDirectoryWatcher.Name = "chbDirectoryWatcher";
            this.chbDirectoryWatcher.Size = new System.Drawing.Size(243, 16);
            this.chbDirectoryWatcher.TabIndex = 46;
            this.chbDirectoryWatcher.Text = "Directory watcher";
            // 
            // chbRegistryWatcher
            // 
            this.chbRegistryWatcher.Checked = false;
            this.chbRegistryWatcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbRegistryWatcher.Location = new System.Drawing.Point(18, 86);
            this.chbRegistryWatcher.Name = "chbRegistryWatcher";
            this.chbRegistryWatcher.Size = new System.Drawing.Size(243, 16);
            this.chbRegistryWatcher.TabIndex = 45;
            this.chbRegistryWatcher.Text = "Registry watcher";
            // 
            // chbVirusTotalEngine
            // 
            this.chbVirusTotalEngine.Checked = false;
            this.chbVirusTotalEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbVirusTotalEngine.Location = new System.Drawing.Point(18, 196);
            this.chbVirusTotalEngine.Name = "chbVirusTotalEngine";
            this.chbVirusTotalEngine.Size = new System.Drawing.Size(243, 16);
            this.chbVirusTotalEngine.TabIndex = 43;
            this.chbVirusTotalEngine.Text = "Improve scans using VirusTotal";
            // 
            // chbFightWithThreats
            // 
            this.chbFightWithThreats.Checked = false;
            this.chbFightWithThreats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbFightWithThreats.Location = new System.Drawing.Point(18, 218);
            this.chbFightWithThreats.Name = "chbFightWithThreats";
            this.chbFightWithThreats.Size = new System.Drawing.Size(243, 16);
            this.chbFightWithThreats.TabIndex = 41;
            this.chbFightWithThreats.Text = "Fight with threats";
            // 
            // chbDynamicEngine
            // 
            this.chbDynamicEngine.Checked = false;
            this.chbDynamicEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbDynamicEngine.Location = new System.Drawing.Point(18, 174);
            this.chbDynamicEngine.Name = "chbDynamicEngine";
            this.chbDynamicEngine.Size = new System.Drawing.Size(243, 16);
            this.chbDynamicEngine.TabIndex = 40;
            this.chbDynamicEngine.Text = "BeSafe dynamic scan engine";
            // 
            // chbStaticEngine
            // 
            this.chbStaticEngine.Checked = false;
            this.chbStaticEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbStaticEngine.Location = new System.Drawing.Point(18, 152);
            this.chbStaticEngine.Name = "chbStaticEngine";
            this.chbStaticEngine.Size = new System.Drawing.Size(243, 16);
            this.chbStaticEngine.TabIndex = 39;
            this.chbStaticEngine.Text = "BeSafe static scan engine";
            // 
            // chbSecureVolume
            // 
            this.chbSecureVolume.Checked = false;
            this.chbSecureVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbSecureVolume.Location = new System.Drawing.Point(18, 130);
            this.chbSecureVolume.Name = "chbSecureVolume";
            this.chbSecureVolume.Size = new System.Drawing.Size(243, 16);
            this.chbSecureVolume.TabIndex = 38;
            this.chbSecureVolume.Text = "BeSafe secure volume";
            // 
            // chbYaraEngine
            // 
            this.chbYaraEngine.Checked = false;
            this.chbYaraEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbYaraEngine.Location = new System.Drawing.Point(18, 108);
            this.chbYaraEngine.Name = "chbYaraEngine";
            this.chbYaraEngine.Size = new System.Drawing.Size(243, 16);
            this.chbYaraEngine.TabIndex = 37;
            this.chbYaraEngine.Text = "Yara scan engine";
            // 
            // chbmoduleWatcher
            // 
            this.chbmoduleWatcher.Checked = false;
            this.chbmoduleWatcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbmoduleWatcher.Location = new System.Drawing.Point(18, 42);
            this.chbmoduleWatcher.Name = "chbmoduleWatcher";
            this.chbmoduleWatcher.Size = new System.Drawing.Size(243, 16);
            this.chbmoduleWatcher.TabIndex = 36;
            this.chbmoduleWatcher.Text = "Module watcher";
            // 
            // chbProcessWatcher
            // 
            this.chbProcessWatcher.Checked = false;
            this.chbProcessWatcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbProcessWatcher.Location = new System.Drawing.Point(18, 20);
            this.chbProcessWatcher.Name = "chbProcessWatcher";
            this.chbProcessWatcher.Size = new System.Drawing.Size(243, 16);
            this.chbProcessWatcher.TabIndex = 35;
            this.chbProcessWatcher.Text = "Process watcher";
            // 
            // tpPlugins
            // 
            this.tpPlugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.tpPlugins.Controls.Add(this.btnUnloadPlugin);
            this.tpPlugins.Controls.Add(this.btnLoadPlugin);
            this.tpPlugins.Controls.Add(this.lbPlugins);
            this.tpPlugins.Location = new System.Drawing.Point(4, 27);
            this.tpPlugins.Name = "tpPlugins";
            this.tpPlugins.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlugins.Size = new System.Drawing.Size(542, 254);
            this.tpPlugins.TabIndex = 1;
            this.tpPlugins.Text = "Plugins";
            // 
            // btnUnloadPlugin
            // 
            this.btnUnloadPlugin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUnloadPlugin.BackColor = System.Drawing.Color.Transparent;
            this.btnUnloadPlugin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUnloadPlugin.Image = null;
            this.btnUnloadPlugin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnloadPlugin.Location = new System.Drawing.Point(139, 213);
            this.btnUnloadPlugin.Name = "btnUnloadPlugin";
            this.btnUnloadPlugin.Size = new System.Drawing.Size(120, 30);
            this.btnUnloadPlugin.TabIndex = 40;
            this.btnUnloadPlugin.Text = "Unload Plugin";
            this.btnUnloadPlugin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnUnloadPlugin.Click += new System.EventHandler(this.btnUnloadPlugin_Click);
            // 
            // btnLoadPlugin
            // 
            this.btnLoadPlugin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadPlugin.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadPlugin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLoadPlugin.Image = null;
            this.btnLoadPlugin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPlugin.Location = new System.Drawing.Point(13, 213);
            this.btnLoadPlugin.Name = "btnLoadPlugin";
            this.btnLoadPlugin.Size = new System.Drawing.Size(120, 30);
            this.btnLoadPlugin.TabIndex = 39;
            this.btnLoadPlugin.Text = "Load Plugin";
            this.btnLoadPlugin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLoadPlugin.Click += new System.EventHandler(this.btnLoadPlugin_Click);
            // 
            // lbPlugins
            // 
            this.lbPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.lbPlugins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPlugins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlugins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lbPlugins.FormattingEnabled = true;
            this.lbPlugins.ItemHeight = 16;
            this.lbPlugins.Location = new System.Drawing.Point(13, 12);
            this.lbPlugins.Name = "lbPlugins";
            this.lbPlugins.Size = new System.Drawing.Size(515, 192);
            this.lbPlugins.TabIndex = 38;
            // 
            // tpFileProtection
            // 
            this.tpFileProtection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.tpFileProtection.Controls.Add(this.btnRemoveFileExtension);
            this.tpFileProtection.Controls.Add(this.btnAddFileExtension);
            this.tpFileProtection.Controls.Add(this.rbtnBlacklist);
            this.tpFileProtection.Controls.Add(this.rbtnWhiteList);
            this.tpFileProtection.Controls.Add(this.lbProtectionExtensions);
            this.tpFileProtection.Location = new System.Drawing.Point(4, 27);
            this.tpFileProtection.Name = "tpFileProtection";
            this.tpFileProtection.Padding = new System.Windows.Forms.Padding(3);
            this.tpFileProtection.Size = new System.Drawing.Size(542, 254);
            this.tpFileProtection.TabIndex = 3;
            this.tpFileProtection.Text = "File Protection";
            // 
            // btnRemoveFileExtension
            // 
            this.btnRemoveFileExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveFileExtension.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveFileExtension.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemoveFileExtension.Image = null;
            this.btnRemoveFileExtension.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveFileExtension.Location = new System.Drawing.Point(169, 213);
            this.btnRemoveFileExtension.Name = "btnRemoveFileExtension";
            this.btnRemoveFileExtension.Size = new System.Drawing.Size(150, 30);
            this.btnRemoveFileExtension.TabIndex = 43;
            this.btnRemoveFileExtension.Text = "Remove Extension";
            this.btnRemoveFileExtension.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRemoveFileExtension.Click += new System.EventHandler(this.btnRemoveFileExtension_Click);
            // 
            // btnAddFileExtension
            // 
            this.btnAddFileExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddFileExtension.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFileExtension.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddFileExtension.Image = null;
            this.btnAddFileExtension.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFileExtension.Location = new System.Drawing.Point(13, 213);
            this.btnAddFileExtension.Name = "btnAddFileExtension";
            this.btnAddFileExtension.Size = new System.Drawing.Size(150, 30);
            this.btnAddFileExtension.TabIndex = 42;
            this.btnAddFileExtension.Text = "Add extension";
            this.btnAddFileExtension.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddFileExtension.Click += new System.EventHandler(this.btnAddFileExtension_Click);
            // 
            // rbtnBlacklist
            // 
            this.rbtnBlacklist.Checked = true;
            this.rbtnBlacklist.Location = new System.Drawing.Point(13, 16);
            this.rbtnBlacklist.Name = "rbtnBlacklist";
            this.rbtnBlacklist.Size = new System.Drawing.Size(73, 17);
            this.rbtnBlacklist.TabIndex = 41;
            this.rbtnBlacklist.Text = "Blacklist";
            // 
            // rbtnWhiteList
            // 
            this.rbtnWhiteList.Checked = false;
            this.rbtnWhiteList.Location = new System.Drawing.Point(94, 16);
            this.rbtnWhiteList.Name = "rbtnWhiteList";
            this.rbtnWhiteList.Size = new System.Drawing.Size(74, 17);
            this.rbtnWhiteList.TabIndex = 40;
            this.rbtnWhiteList.Text = "Whitelist";
            // 
            // lbProtectionExtensions
            // 
            this.lbProtectionExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProtectionExtensions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.lbProtectionExtensions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProtectionExtensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProtectionExtensions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lbProtectionExtensions.FormattingEnabled = true;
            this.lbProtectionExtensions.ItemHeight = 16;
            this.lbProtectionExtensions.Location = new System.Drawing.Point(13, 44);
            this.lbProtectionExtensions.Name = "lbProtectionExtensions";
            this.lbProtectionExtensions.Size = new System.Drawing.Size(515, 160);
            this.lbProtectionExtensions.TabIndex = 39;
            // 
            // tpAccount
            // 
            this.tpAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.tpAccount.Controls.Add(this.chbUseSystemProxy);
            this.tpAccount.Controls.Add(this.lbllVTApiKey);
            this.tpAccount.Controls.Add(this.tbVTApiKey);
            this.tpAccount.Location = new System.Drawing.Point(4, 27);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(542, 254);
            this.tpAccount.TabIndex = 2;
            this.tpAccount.Text = "Account";
            // 
            // lbllVTApiKey
            // 
            this.lbllVTApiKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbllVTApiKey.AutoSize = true;
            this.lbllVTApiKey.BackColor = System.Drawing.Color.Transparent;
            this.lbllVTApiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbllVTApiKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lbllVTApiKey.Location = new System.Drawing.Point(15, 172);
            this.lbllVTApiKey.Name = "lbllVTApiKey";
            this.lbllVTApiKey.Size = new System.Drawing.Size(105, 15);
            this.lbllVTApiKey.TabIndex = 2;
            this.lbllVTApiKey.Text = "VirusTotal API Key";
            // 
            // tbVTApiKey
            // 
            this.tbVTApiKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbVTApiKey.BackColor = System.Drawing.Color.Transparent;
            this.tbVTApiKey.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVTApiKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.tbVTApiKey.Image = null;
            this.tbVTApiKey.Location = new System.Drawing.Point(18, 190);
            this.tbVTApiKey.MaxLength = 32767;
            this.tbVTApiKey.Multiline = false;
            this.tbVTApiKey.Name = "tbVTApiKey";
            this.tbVTApiKey.ReadOnly = false;
            this.tbVTApiKey.Size = new System.Drawing.Size(506, 43);
            this.tbVTApiKey.TabIndex = 1;
            this.tbVTApiKey.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbVTApiKey.UseSystemPasswordChar = false;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(15, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(45, 60);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 23;
            this.Logo.TabStop = false;
            // 
            // monoFlat_HeaderLabel1
            // 
            this.monoFlat_HeaderLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monoFlat_HeaderLabel1.AutoSize = true;
            this.monoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.Black;
            this.monoFlat_HeaderLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_HeaderLabel1.Location = new System.Drawing.Point(224, 7);
            this.monoFlat_HeaderLabel1.Name = "monoFlat_HeaderLabel1";
            this.monoFlat_HeaderLabel1.Size = new System.Drawing.Size(128, 46);
            this.monoFlat_HeaderLabel1.TabIndex = 35;
            this.monoFlat_HeaderLabel1.Text = "BeSafe";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnApply.Image = null;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(471, 374);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 41);
            this.btnApply.TabIndex = 24;
            this.btnApply.Text = "Apply";
            this.btnApply.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnApply.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // openPluginFileDialog
            // 
            this.openPluginFileDialog.Filter = "BeSafe Plugin Files|*.bsp";
            // 
            // chbUseSystemProxy
            // 
            this.chbUseSystemProxy.Checked = false;
            this.chbUseSystemProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbUseSystemProxy.Location = new System.Drawing.Point(18, 20);
            this.chbUseSystemProxy.Name = "chbUseSystemProxy";
            this.chbUseSystemProxy.Size = new System.Drawing.Size(148, 16);
            this.chbUseSystemProxy.TabIndex = 3;
            this.chbUseSystemProxy.Text = "Use system proxy";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 427);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_FormClosing);
            this.Resize += new System.EventHandler(this.Setting_Resize);
            this.TryIconMenu.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpConfiguration.ResumeLayout(false);
            this.tpPlugins.ResumeLayout(false);
            this.tpFileProtection.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.tpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip TryIconMenu;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private System.Windows.Forms.PictureBox Logo;
        private MonoFlat_Button btnApply;
        private MonoFlat_HeaderLabel monoFlat_HeaderLabel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpConfiguration;
        public MonoFlat_CheckBox chbVirusTotalEngine;
        public MonoFlat_CheckBox chbFightWithThreats;
        public MonoFlat_CheckBox chbDynamicEngine;
        public MonoFlat_CheckBox chbStaticEngine;
        public MonoFlat_CheckBox chbSecureVolume;
        public MonoFlat_CheckBox chbYaraEngine;
        public MonoFlat_CheckBox chbmoduleWatcher;
        public MonoFlat_CheckBox chbProcessWatcher;
        private System.Windows.Forms.TabPage tpPlugins;
        private MonoFlat_Button btnUnloadPlugin;
        private MonoFlat_Button btnLoadPlugin;
        private System.Windows.Forms.TabPage tpAccount;
        private MonoFlat_Label lbllVTApiKey;
        public MonoFlat_TextBox tbVTApiKey;
        private MonoFlat_ControlBox monoFlat_ControlBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openPluginFileDialog;
        public MonoFlat_CheckBox chbRegistryWatcher;
        private System.Windows.Forms.ToolStripMenuItem logHistoryToolStripMenuItem;
        public MonoFlat_CheckBox chbDirectoryWatcher;
        private System.Windows.Forms.ListBox lbPlugins;
        private System.Windows.Forms.TabPage tpFileProtection;
        public System.Windows.Forms.ListBox lbProtectionExtensions;
        public MonoFlat_RadioButton rbtnBlacklist;
        public MonoFlat_RadioButton rbtnWhiteList;
        private MonoFlat_Button btnRemoveFileExtension;
        private MonoFlat_Button btnAddFileExtension;
        public MonoFlat_CheckBox chbUseSystemProxy;
    }
}