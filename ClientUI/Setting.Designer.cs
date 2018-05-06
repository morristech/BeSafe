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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TryIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chbProcessWatcher = new System.Windows.Forms.CheckBox();
            this.chbyaraEngine = new System.Windows.Forms.CheckBox();
            this.chbStaticEngine = new System.Windows.Forms.CheckBox();
            this.chbDynamicEngine = new System.Windows.Forms.CheckBox();
            this.chbSecureVolume = new System.Windows.Forms.CheckBox();
            this.chbKillSuspicious = new System.Windows.Forms.CheckBox();
            this.chbQuarantineSuspicious = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chbVirusTotalEngine = new System.Windows.Forms.CheckBox();
            this.chbmoduleWatcher = new System.Windows.Forms.CheckBox();
            this.TryIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "BeSafe";
            this.notifyIcon.ContextMenuStrip = this.TryIconMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "BeSafe";
            this.notifyIcon.Visible = true;
            // 
            // TryIconMenu
            // 
            this.TryIconMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TryIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.TryIconMenu.Name = "TryIconMenu";
            this.TryIconMenu.Size = new System.Drawing.Size(120, 52);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // chbProcessWatcher
            // 
            this.chbProcessWatcher.AutoSize = true;
            this.chbProcessWatcher.Location = new System.Drawing.Point(24, 22);
            this.chbProcessWatcher.Name = "chbProcessWatcher";
            this.chbProcessWatcher.Size = new System.Drawing.Size(134, 21);
            this.chbProcessWatcher.TabIndex = 1;
            this.chbProcessWatcher.Text = "Process watcher";
            this.chbProcessWatcher.UseVisualStyleBackColor = true;
            // 
            // chbyaraEngine
            // 
            this.chbyaraEngine.AutoSize = true;
            this.chbyaraEngine.Location = new System.Drawing.Point(24, 76);
            this.chbyaraEngine.Name = "chbyaraEngine";
            this.chbyaraEngine.Size = new System.Drawing.Size(141, 21);
            this.chbyaraEngine.TabIndex = 2;
            this.chbyaraEngine.Text = "Yara scan engine";
            this.chbyaraEngine.UseVisualStyleBackColor = true;
            // 
            // chbStaticEngine
            // 
            this.chbStaticEngine.AutoSize = true;
            this.chbStaticEngine.Location = new System.Drawing.Point(24, 130);
            this.chbStaticEngine.Name = "chbStaticEngine";
            this.chbStaticEngine.Size = new System.Drawing.Size(194, 21);
            this.chbStaticEngine.TabIndex = 3;
            this.chbStaticEngine.Text = "BeSafe static scan engine";
            this.chbStaticEngine.UseVisualStyleBackColor = true;
            // 
            // chbDynamicEngine
            // 
            this.chbDynamicEngine.AutoSize = true;
            this.chbDynamicEngine.Location = new System.Drawing.Point(24, 157);
            this.chbDynamicEngine.Name = "chbDynamicEngine";
            this.chbDynamicEngine.Size = new System.Drawing.Size(213, 21);
            this.chbDynamicEngine.TabIndex = 4;
            this.chbDynamicEngine.Text = "BeSafe dynamic scan engine";
            this.chbDynamicEngine.UseVisualStyleBackColor = true;
            // 
            // chbSecureVolume
            // 
            this.chbSecureVolume.AutoSize = true;
            this.chbSecureVolume.Location = new System.Drawing.Point(24, 103);
            this.chbSecureVolume.Name = "chbSecureVolume";
            this.chbSecureVolume.Size = new System.Drawing.Size(172, 21);
            this.chbSecureVolume.TabIndex = 5;
            this.chbSecureVolume.Text = "BeSafe secure volume";
            this.chbSecureVolume.UseVisualStyleBackColor = true;
            // 
            // chbKillSuspicious
            // 
            this.chbKillSuspicious.AutoSize = true;
            this.chbKillSuspicious.Location = new System.Drawing.Point(24, 184);
            this.chbKillSuspicious.Name = "chbKillSuspicious";
            this.chbKillSuspicious.Size = new System.Drawing.Size(261, 21);
            this.chbKillSuspicious.TabIndex = 6;
            this.chbKillSuspicious.Text = "Automatically kill suspicious process ";
            this.chbKillSuspicious.UseVisualStyleBackColor = true;
            // 
            // chbQuarantineSuspicious
            // 
            this.chbQuarantineSuspicious.AutoSize = true;
            this.chbQuarantineSuspicious.Location = new System.Drawing.Point(24, 211);
            this.chbQuarantineSuspicious.Name = "chbQuarantineSuspicious";
            this.chbQuarantineSuspicious.Size = new System.Drawing.Size(284, 21);
            this.chbQuarantineSuspicious.TabIndex = 7;
            this.chbQuarantineSuspicious.Text = "Automatically quarantine suspicious files";
            this.chbQuarantineSuspicious.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(495, 318);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(414, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chbVirusTotalEngine
            // 
            this.chbVirusTotalEngine.AutoSize = true;
            this.chbVirusTotalEngine.Location = new System.Drawing.Point(24, 238);
            this.chbVirusTotalEngine.Name = "chbVirusTotalEngine";
            this.chbVirusTotalEngine.Size = new System.Drawing.Size(285, 21);
            this.chbVirusTotalEngine.TabIndex = 10;
            this.chbVirusTotalEngine.Text = "Improve scans using power of VirusTotal";
            this.chbVirusTotalEngine.UseVisualStyleBackColor = true;
            // 
            // chbmoduleWatcher
            // 
            this.chbmoduleWatcher.AutoSize = true;
            this.chbmoduleWatcher.Location = new System.Drawing.Point(24, 49);
            this.chbmoduleWatcher.Name = "chbmoduleWatcher";
            this.chbmoduleWatcher.Size = new System.Drawing.Size(129, 21);
            this.chbmoduleWatcher.TabIndex = 11;
            this.chbmoduleWatcher.Text = "Module watcher";
            this.chbmoduleWatcher.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.chbmoduleWatcher);
            this.Controls.Add(this.chbVirusTotalEngine);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chbQuarantineSuspicious);
            this.Controls.Add(this.chbKillSuspicious);
            this.Controls.Add(this.chbSecureVolume);
            this.Controls.Add(this.chbDynamicEngine);
            this.Controls.Add(this.chbStaticEngine);
            this.Controls.Add(this.chbyaraEngine);
            this.Controls.Add(this.chbProcessWatcher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeSafe";
            this.TryIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip TryIconMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.CheckBox chbProcessWatcher;
        private System.Windows.Forms.CheckBox chbyaraEngine;
        private System.Windows.Forms.CheckBox chbStaticEngine;
        private System.Windows.Forms.CheckBox chbDynamicEngine;
        private System.Windows.Forms.CheckBox chbSecureVolume;
        private System.Windows.Forms.CheckBox chbKillSuspicious;
        private System.Windows.Forms.CheckBox chbQuarantineSuspicious;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chbVirusTotalEngine;
        private System.Windows.Forms.CheckBox chbmoduleWatcher;
    }
}

