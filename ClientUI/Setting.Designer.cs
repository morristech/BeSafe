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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.monoFlat_ThemeContainer1 = new ClientUI.MonoFlat_ThemeContainer();
            this.monoFlat_ControlBox1 = new ClientUI.MonoFlat_ControlBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.chbProtectorDetector = new ClientUI.MonoFlat_CheckBox();
            this.chbVirusTotalEngine = new ClientUI.MonoFlat_CheckBox();
            this.chbQuarantineSuspicious = new ClientUI.MonoFlat_CheckBox();
            this.chbKillSuspicious = new ClientUI.MonoFlat_CheckBox();
            this.chbDynamicEngine = new ClientUI.MonoFlat_CheckBox();
            this.chbStaticEngine = new ClientUI.MonoFlat_CheckBox();
            this.chbSecureVolume = new ClientUI.MonoFlat_CheckBox();
            this.chbYaraEngine = new ClientUI.MonoFlat_CheckBox();
            this.chbmoduleWatcher = new ClientUI.MonoFlat_CheckBox();
            this.chbProcessWatcher = new ClientUI.MonoFlat_CheckBox();
            this.tpSecureVolumePlugins = new System.Windows.Forms.TabPage();
            this.btnUnloadPlugin = new ClientUI.MonoFlat_Button();
            this.btnLoadPlugin = new ClientUI.MonoFlat_Button();
            this.lbPlugins = new System.Windows.Forms.ListBox();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.tbPassword = new ClientUI.MonoFlat_TextBox();
            this.lblPassword = new ClientUI.MonoFlat_Label();
            this.lblUsername = new ClientUI.MonoFlat_Label();
            this.tbUsername = new ClientUI.MonoFlat_TextBox();
            this.btnLogin = new ClientUI.MonoFlat_Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.monoFlat_HeaderLabel1 = new ClientUI.MonoFlat_HeaderLabel();
            this.btnApply = new ClientUI.MonoFlat_Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TryIconMenu.SuspendLayout();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpConfiguration.SuspendLayout();
            this.tpSecureVolumePlugins.SuspendLayout();
            this.tpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // TryIconMenu
            // 
            this.TryIconMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TryIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.TryIconMenu.Name = "TryIconMenu";
            this.TryIconMenu.Size = new System.Drawing.Size(181, 92);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "BeSafe";
            this.notifyIcon.ContextMenuStrip = this.TryIconMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "BeSafe";
            this.notifyIcon.Visible = true;
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
            this.tabControl.Controls.Add(this.tpSecureVolumePlugins);
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
            this.tpConfiguration.Controls.Add(this.chbProtectorDetector);
            this.tpConfiguration.Controls.Add(this.chbVirusTotalEngine);
            this.tpConfiguration.Controls.Add(this.chbQuarantineSuspicious);
            this.tpConfiguration.Controls.Add(this.chbKillSuspicious);
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
            // chbProtectorDetector
            // 
            this.chbProtectorDetector.Checked = false;
            this.chbProtectorDetector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbProtectorDetector.Location = new System.Drawing.Point(293, 24);
            this.chbProtectorDetector.Name = "chbProtectorDetector";
            this.chbProtectorDetector.Size = new System.Drawing.Size(243, 16);
            this.chbProtectorDetector.TabIndex = 44;
            this.chbProtectorDetector.Text = "Protector Detector Engine";
            // 
            // chbVirusTotalEngine
            // 
            this.chbVirusTotalEngine.Checked = false;
            this.chbVirusTotalEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbVirusTotalEngine.Location = new System.Drawing.Point(18, 200);
            this.chbVirusTotalEngine.Name = "chbVirusTotalEngine";
            this.chbVirusTotalEngine.Size = new System.Drawing.Size(243, 16);
            this.chbVirusTotalEngine.TabIndex = 43;
            this.chbVirusTotalEngine.Text = "Improve scans using VirusTotal";
            // 
            // chbQuarantineSuspicious
            // 
            this.chbQuarantineSuspicious.Checked = false;
            this.chbQuarantineSuspicious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbQuarantineSuspicious.Location = new System.Drawing.Point(18, 178);
            this.chbQuarantineSuspicious.Name = "chbQuarantineSuspicious";
            this.chbQuarantineSuspicious.Size = new System.Drawing.Size(243, 16);
            this.chbQuarantineSuspicious.TabIndex = 42;
            this.chbQuarantineSuspicious.Text = "Automatically quarantine suspicious files";
            // 
            // chbKillSuspicious
            // 
            this.chbKillSuspicious.Checked = false;
            this.chbKillSuspicious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbKillSuspicious.Location = new System.Drawing.Point(18, 156);
            this.chbKillSuspicious.Name = "chbKillSuspicious";
            this.chbKillSuspicious.Size = new System.Drawing.Size(243, 16);
            this.chbKillSuspicious.TabIndex = 41;
            this.chbKillSuspicious.Text = "Automatically kill suspicious process ";
            // 
            // chbDynamicEngine
            // 
            this.chbDynamicEngine.Checked = false;
            this.chbDynamicEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbDynamicEngine.Location = new System.Drawing.Point(18, 134);
            this.chbDynamicEngine.Name = "chbDynamicEngine";
            this.chbDynamicEngine.Size = new System.Drawing.Size(243, 16);
            this.chbDynamicEngine.TabIndex = 40;
            this.chbDynamicEngine.Text = "BeSafe dynamic scan engine";
            // 
            // chbStaticEngine
            // 
            this.chbStaticEngine.Checked = false;
            this.chbStaticEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbStaticEngine.Location = new System.Drawing.Point(18, 112);
            this.chbStaticEngine.Name = "chbStaticEngine";
            this.chbStaticEngine.Size = new System.Drawing.Size(243, 16);
            this.chbStaticEngine.TabIndex = 39;
            this.chbStaticEngine.Text = "BeSafe static scan engine";
            // 
            // chbSecureVolume
            // 
            this.chbSecureVolume.Checked = false;
            this.chbSecureVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbSecureVolume.Location = new System.Drawing.Point(18, 90);
            this.chbSecureVolume.Name = "chbSecureVolume";
            this.chbSecureVolume.Size = new System.Drawing.Size(243, 16);
            this.chbSecureVolume.TabIndex = 38;
            this.chbSecureVolume.Text = "BeSafe secure volume";
            // 
            // chbYaraEngine
            // 
            this.chbYaraEngine.Checked = false;
            this.chbYaraEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbYaraEngine.Location = new System.Drawing.Point(18, 68);
            this.chbYaraEngine.Name = "chbYaraEngine";
            this.chbYaraEngine.Size = new System.Drawing.Size(243, 16);
            this.chbYaraEngine.TabIndex = 37;
            this.chbYaraEngine.Text = "Yara scan engine";
            // 
            // chbmoduleWatcher
            // 
            this.chbmoduleWatcher.Checked = false;
            this.chbmoduleWatcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbmoduleWatcher.Location = new System.Drawing.Point(18, 46);
            this.chbmoduleWatcher.Name = "chbmoduleWatcher";
            this.chbmoduleWatcher.Size = new System.Drawing.Size(243, 16);
            this.chbmoduleWatcher.TabIndex = 36;
            this.chbmoduleWatcher.Text = "Module watcher";
            // 
            // chbProcessWatcher
            // 
            this.chbProcessWatcher.Checked = false;
            this.chbProcessWatcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbProcessWatcher.Location = new System.Drawing.Point(18, 24);
            this.chbProcessWatcher.Name = "chbProcessWatcher";
            this.chbProcessWatcher.Size = new System.Drawing.Size(243, 16);
            this.chbProcessWatcher.TabIndex = 35;
            this.chbProcessWatcher.Text = "Process watcher";
            // 
            // tpSecureVolumePlugins
            // 
            this.tpSecureVolumePlugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.tpSecureVolumePlugins.Controls.Add(this.btnUnloadPlugin);
            this.tpSecureVolumePlugins.Controls.Add(this.btnLoadPlugin);
            this.tpSecureVolumePlugins.Controls.Add(this.lbPlugins);
            this.tpSecureVolumePlugins.Location = new System.Drawing.Point(4, 27);
            this.tpSecureVolumePlugins.Name = "tpSecureVolumePlugins";
            this.tpSecureVolumePlugins.Padding = new System.Windows.Forms.Padding(3);
            this.tpSecureVolumePlugins.Size = new System.Drawing.Size(542, 254);
            this.tpSecureVolumePlugins.TabIndex = 1;
            this.tpSecureVolumePlugins.Text = "Secure Volume Plugins";
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
            // tpAccount
            // 
            this.tpAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.tpAccount.Controls.Add(this.tbPassword);
            this.tpAccount.Controls.Add(this.lblPassword);
            this.tpAccount.Controls.Add(this.lblUsername);
            this.tpAccount.Controls.Add(this.tbUsername);
            this.tpAccount.Controls.Add(this.btnLogin);
            this.tpAccount.Location = new System.Drawing.Point(4, 27);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(542, 254);
            this.tpAccount.TabIndex = 2;
            this.tpAccount.Text = "Account";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.tbPassword.Image = null;
            this.tbPassword.Location = new System.Drawing.Point(167, 94);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ReadOnly = false;
            this.tbPassword.Size = new System.Drawing.Size(210, 43);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblPassword.Location = new System.Drawing.Point(56, 102);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 21);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblUsername.Location = new System.Drawing.Point(56, 57);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 21);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsername.BackColor = System.Drawing.Color.Transparent;
            this.tbUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.tbUsername.Image = null;
            this.tbUsername.Location = new System.Drawing.Point(167, 47);
            this.tbUsername.MaxLength = 32767;
            this.tbUsername.Multiline = false;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = false;
            this.tbUsername.Size = new System.Drawing.Size(210, 43);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUsername.UseSystemPasswordChar = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogin.Image = null;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(297, 142);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 30);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlignment = System.Drawing.StringAlignment.Center;
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_FormClosing);
            this.Resize += new System.EventHandler(this.Setting_Resize);
            this.TryIconMenu.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpConfiguration.ResumeLayout(false);
            this.tpSecureVolumePlugins.ResumeLayout(false);
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
        private MonoFlat_CheckBox chbVirusTotalEngine;
        private MonoFlat_CheckBox chbQuarantineSuspicious;
        private MonoFlat_CheckBox chbKillSuspicious;
        private MonoFlat_CheckBox chbDynamicEngine;
        private MonoFlat_CheckBox chbStaticEngine;
        private MonoFlat_CheckBox chbSecureVolume;
        private MonoFlat_CheckBox chbYaraEngine;
        private MonoFlat_CheckBox chbmoduleWatcher;
        private MonoFlat_CheckBox chbProcessWatcher;
        private System.Windows.Forms.TabPage tpSecureVolumePlugins;
        private MonoFlat_Button btnUnloadPlugin;
        private MonoFlat_Button btnLoadPlugin;
        private System.Windows.Forms.ListBox lbPlugins;
        private System.Windows.Forms.TabPage tpAccount;
        private MonoFlat_TextBox tbPassword;
        private MonoFlat_Label lblPassword;
        private MonoFlat_Label lblUsername;
        private MonoFlat_TextBox tbUsername;
        private MonoFlat_Button btnLogin;
        private MonoFlat_CheckBox chbProtectorDetector;
        private MonoFlat_ControlBox monoFlat_ControlBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

