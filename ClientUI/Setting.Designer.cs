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
            this.chbVirusTotalEngine = new ClientUI.MonoFlat_CheckBox();
            this.chbQuarantineSuspicious = new ClientUI.MonoFlat_CheckBox();
            this.chbKillSuspicious = new ClientUI.MonoFlat_CheckBox();
            this.chbDynamicEngine = new ClientUI.MonoFlat_CheckBox();
            this.chbStaticEngine = new ClientUI.MonoFlat_CheckBox();
            this.chbSecureVolume = new ClientUI.MonoFlat_CheckBox();
            this.chbyaraEngine = new ClientUI.MonoFlat_CheckBox();
            this.chbmoduleWatcher = new ClientUI.MonoFlat_CheckBox();
            this.chbProcessWatcher = new ClientUI.MonoFlat_CheckBox();
            this.btnCancel = new ClientUI.MonoFlat_Button();
            this.btnOk = new ClientUI.MonoFlat_Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.TryIconMenu.SuspendLayout();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // TryIconMenu
            // 
            this.TryIconMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TryIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.TryIconMenu.Name = "TryIconMenu";
            this.TryIconMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "BeSafe";
            this.notifyIcon.ContextMenuStrip = this.TryIconMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "BeSafe";
            this.notifyIcon.Visible = true;
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.chbVirusTotalEngine);
            this.monoFlat_ThemeContainer1.Controls.Add(this.chbQuarantineSuspicious);
            this.monoFlat_ThemeContainer1.Controls.Add(this.chbKillSuspicious);
            this.monoFlat_ThemeContainer1.Controls.Add(this.chbDynamicEngine);
            this.monoFlat_ThemeContainer1.Controls.Add(this.chbStaticEngine);
            this.monoFlat_ThemeContainer1.Controls.Add(this.chbSecureVolume);
            this.monoFlat_ThemeContainer1.Controls.Add(this.chbyaraEngine);
            this.monoFlat_ThemeContainer1.Controls.Add(this.chbmoduleWatcher);
            this.monoFlat_ThemeContainer1.Controls.Add(this.chbProcessWatcher);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnCancel);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnOk);
            this.monoFlat_ThemeContainer1.Controls.Add(this.Logo);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(575, 383);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.monoFlat_ThemeContainer1.TabIndex = 1;
            // 
            // chbVirusTotalEngine
            // 
            this.chbVirusTotalEngine.Checked = false;
            this.chbVirusTotalEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbVirusTotalEngine.Location = new System.Drawing.Point(26, 264);
            this.chbVirusTotalEngine.Name = "chbVirusTotalEngine";
            this.chbVirusTotalEngine.Size = new System.Drawing.Size(283, 16);
            this.chbVirusTotalEngine.TabIndex = 34;
            this.chbVirusTotalEngine.Text = "Improve scans using VirusTotal";
            // 
            // chbQuarantineSuspicious
            // 
            this.chbQuarantineSuspicious.Checked = false;
            this.chbQuarantineSuspicious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbQuarantineSuspicious.Location = new System.Drawing.Point(26, 242);
            this.chbQuarantineSuspicious.Name = "chbQuarantineSuspicious";
            this.chbQuarantineSuspicious.Size = new System.Drawing.Size(283, 16);
            this.chbQuarantineSuspicious.TabIndex = 33;
            this.chbQuarantineSuspicious.Text = "Automatically quarantine suspicious files";
            // 
            // chbKillSuspicious
            // 
            this.chbKillSuspicious.Checked = false;
            this.chbKillSuspicious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbKillSuspicious.Location = new System.Drawing.Point(26, 220);
            this.chbKillSuspicious.Name = "chbKillSuspicious";
            this.chbKillSuspicious.Size = new System.Drawing.Size(283, 16);
            this.chbKillSuspicious.TabIndex = 32;
            this.chbKillSuspicious.Text = "Automatically kill suspicious process ";
            // 
            // chbDynamicEngine
            // 
            this.chbDynamicEngine.Checked = false;
            this.chbDynamicEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbDynamicEngine.Location = new System.Drawing.Point(26, 198);
            this.chbDynamicEngine.Name = "chbDynamicEngine";
            this.chbDynamicEngine.Size = new System.Drawing.Size(283, 16);
            this.chbDynamicEngine.TabIndex = 31;
            this.chbDynamicEngine.Text = "BeSafe dynamic scan engine";
            // 
            // chbStaticEngine
            // 
            this.chbStaticEngine.Checked = false;
            this.chbStaticEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbStaticEngine.Location = new System.Drawing.Point(26, 176);
            this.chbStaticEngine.Name = "chbStaticEngine";
            this.chbStaticEngine.Size = new System.Drawing.Size(283, 16);
            this.chbStaticEngine.TabIndex = 30;
            this.chbStaticEngine.Text = "BeSafe static scan engine";
            // 
            // chbSecureVolume
            // 
            this.chbSecureVolume.Checked = false;
            this.chbSecureVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbSecureVolume.Location = new System.Drawing.Point(26, 154);
            this.chbSecureVolume.Name = "chbSecureVolume";
            this.chbSecureVolume.Size = new System.Drawing.Size(283, 16);
            this.chbSecureVolume.TabIndex = 29;
            this.chbSecureVolume.Text = "BeSafe secure volume";
            // 
            // chbyaraEngine
            // 
            this.chbyaraEngine.Checked = false;
            this.chbyaraEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbyaraEngine.Location = new System.Drawing.Point(26, 132);
            this.chbyaraEngine.Name = "chbyaraEngine";
            this.chbyaraEngine.Size = new System.Drawing.Size(283, 16);
            this.chbyaraEngine.TabIndex = 28;
            this.chbyaraEngine.Text = "Yara scan engine";
            // 
            // chbmoduleWatcher
            // 
            this.chbmoduleWatcher.Checked = false;
            this.chbmoduleWatcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbmoduleWatcher.Location = new System.Drawing.Point(26, 110);
            this.chbmoduleWatcher.Name = "chbmoduleWatcher";
            this.chbmoduleWatcher.Size = new System.Drawing.Size(283, 16);
            this.chbmoduleWatcher.TabIndex = 27;
            this.chbmoduleWatcher.Text = "Module watcher";
            // 
            // chbProcessWatcher
            // 
            this.chbProcessWatcher.Checked = false;
            this.chbProcessWatcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbProcessWatcher.Location = new System.Drawing.Point(26, 88);
            this.chbProcessWatcher.Name = "chbProcessWatcher";
            this.chbProcessWatcher.Size = new System.Drawing.Size(283, 16);
            this.chbProcessWatcher.TabIndex = 26;
            this.chbProcessWatcher.Text = "Process watcher";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Image = null;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(357, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 41);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOk.Image = null;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(463, 330);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 41);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "Ok";
            this.btnOk.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::ClientUI.Properties.Resources.besafe_logo;
            this.Logo.Location = new System.Drawing.Point(11, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(45, 60);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 23;
            this.Logo.TabStop = false;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 383);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.TryIconMenu.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
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
        private MonoFlat_Button btnCancel;
        private MonoFlat_Button btnOk;
        private MonoFlat_CheckBox chbVirusTotalEngine;
        private MonoFlat_CheckBox chbQuarantineSuspicious;
        private MonoFlat_CheckBox chbKillSuspicious;
        private MonoFlat_CheckBox chbDynamicEngine;
        private MonoFlat_CheckBox chbStaticEngine;
        private MonoFlat_CheckBox chbSecureVolume;
        private MonoFlat_CheckBox chbyaraEngine;
        private MonoFlat_CheckBox chbmoduleWatcher;
        private MonoFlat_CheckBox chbProcessWatcher;
    }
}

