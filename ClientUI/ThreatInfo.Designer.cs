namespace ClientUI
{
    partial class ThreatInfo
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
            this.ThreatInfoTheme = new ClientUI.MonoFlat_ThemeContainer();
            this.lblThreatInfo = new ClientUI.MonoFlat_Label();
            this.monoFlat_Panel2 = new ClientUI.MonoFlat_Panel();
            this.pbRiskRate = new System.Windows.Forms.PictureBox();
            this.lblThreatObject = new ClientUI.MonoFlat_Label();
            this.lblRisk = new ClientUI.MonoFlat_Label();
            this.lblMessage = new ClientUI.MonoFlat_Label();
            this.lblMessageTitle = new ClientUI.MonoFlat_Label();
            this.lblRiskRateTitle = new ClientUI.MonoFlat_Label();
            this.lblScannedObjectTitle = new ClientUI.MonoFlat_Label();
            this.lblPluginInfo = new ClientUI.MonoFlat_Label();
            this.monoFlat_Panel1 = new ClientUI.MonoFlat_Panel();
            this.lblPluginDescription = new ClientUI.MonoFlat_Label();
            this.lblPluginNameAndVersion = new ClientUI.MonoFlat_Label();
            this.btnOk = new ClientUI.MonoFlat_Button();
            this.ThreatInfoTheme.SuspendLayout();
            this.monoFlat_Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRiskRate)).BeginInit();
            this.monoFlat_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThreatInfoTheme
            // 
            this.ThreatInfoTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ThreatInfoTheme.Controls.Add(this.lblThreatInfo);
            this.ThreatInfoTheme.Controls.Add(this.monoFlat_Panel2);
            this.ThreatInfoTheme.Controls.Add(this.lblPluginInfo);
            this.ThreatInfoTheme.Controls.Add(this.monoFlat_Panel1);
            this.ThreatInfoTheme.Controls.Add(this.btnOk);
            this.ThreatInfoTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreatInfoTheme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ThreatInfoTheme.Location = new System.Drawing.Point(0, 0);
            this.ThreatInfoTheme.Name = "ThreatInfoTheme";
            this.ThreatInfoTheme.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.ThreatInfoTheme.RoundCorners = true;
            this.ThreatInfoTheme.Sizable = true;
            this.ThreatInfoTheme.Size = new System.Drawing.Size(698, 458);
            this.ThreatInfoTheme.SmartBounds = true;
            this.ThreatInfoTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ThreatInfoTheme.TabIndex = 0;
            this.ThreatInfoTheme.Text = "Threat Info";
            // 
            // lblThreatInfo
            // 
            this.lblThreatInfo.AutoSize = true;
            this.lblThreatInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblThreatInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThreatInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblThreatInfo.Location = new System.Drawing.Point(13, 179);
            this.lblThreatInfo.Name = "lblThreatInfo";
            this.lblThreatInfo.Size = new System.Drawing.Size(135, 19);
            this.lblThreatInfo.TabIndex = 7;
            this.lblThreatInfo.Text = "Threat Information";
            // 
            // monoFlat_Panel2
            // 
            this.monoFlat_Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.monoFlat_Panel2.Controls.Add(this.pbRiskRate);
            this.monoFlat_Panel2.Controls.Add(this.lblThreatObject);
            this.monoFlat_Panel2.Controls.Add(this.lblRisk);
            this.monoFlat_Panel2.Controls.Add(this.lblMessage);
            this.monoFlat_Panel2.Controls.Add(this.lblMessageTitle);
            this.monoFlat_Panel2.Controls.Add(this.lblRiskRateTitle);
            this.monoFlat_Panel2.Controls.Add(this.lblScannedObjectTitle);
            this.monoFlat_Panel2.Location = new System.Drawing.Point(13, 205);
            this.monoFlat_Panel2.Name = "monoFlat_Panel2";
            this.monoFlat_Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.monoFlat_Panel2.Size = new System.Drawing.Size(672, 183);
            this.monoFlat_Panel2.TabIndex = 6;
            this.monoFlat_Panel2.Text = "monoFlat_Panel2";
            // 
            // pbRiskRate
            // 
            this.pbRiskRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRiskRate.BackColor = System.Drawing.Color.Transparent;
            this.pbRiskRate.Image = global::ClientUI.Properties.Resources.warning___yellow;
            this.pbRiskRate.Location = new System.Drawing.Point(606, 122);
            this.pbRiskRate.Name = "pbRiskRate";
            this.pbRiskRate.Size = new System.Drawing.Size(48, 48);
            this.pbRiskRate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRiskRate.TabIndex = 6;
            this.pbRiskRate.TabStop = false;
            // 
            // lblThreatObject
            // 
            this.lblThreatObject.BackColor = System.Drawing.Color.Transparent;
            this.lblThreatObject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThreatObject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblThreatObject.Location = new System.Drawing.Point(112, 13);
            this.lblThreatObject.Name = "lblThreatObject";
            this.lblThreatObject.Size = new System.Drawing.Size(542, 106);
            this.lblThreatObject.TabIndex = 9;
            this.lblThreatObject.Text = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run\r\nOriginal Value :" +
    " Test\r\nCurrent Value : threat.exe";
            // 
            // lblRisk
            // 
            this.lblRisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRisk.AutoSize = true;
            this.lblRisk.BackColor = System.Drawing.Color.Transparent;
            this.lblRisk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblRisk.Location = new System.Drawing.Point(112, 133);
            this.lblRisk.Name = "lblRisk";
            this.lblRisk.Size = new System.Drawing.Size(56, 15);
            this.lblRisk.TabIndex = 8;
            this.lblRisk.Text = "Low Risk";
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblMessage.Location = new System.Drawing.Point(112, 155);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(99, 15);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Sample message";
            // 
            // lblMessageTitle
            // 
            this.lblMessageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessageTitle.AutoSize = true;
            this.lblMessageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMessageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblMessageTitle.Location = new System.Drawing.Point(8, 155);
            this.lblMessageTitle.Name = "lblMessageTitle";
            this.lblMessageTitle.Size = new System.Drawing.Size(64, 15);
            this.lblMessageTitle.TabIndex = 6;
            this.lblMessageTitle.Text = "Message : ";
            // 
            // lblRiskRateTitle
            // 
            this.lblRiskRateTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRiskRateTitle.AutoSize = true;
            this.lblRiskRateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRiskRateTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRiskRateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblRiskRateTitle.Location = new System.Drawing.Point(8, 133);
            this.lblRiskRateTitle.Name = "lblRiskRateTitle";
            this.lblRiskRateTitle.Size = new System.Drawing.Size(39, 15);
            this.lblRiskRateTitle.TabIndex = 5;
            this.lblRiskRateTitle.Text = "Risk : ";
            // 
            // lblScannedObjectTitle
            // 
            this.lblScannedObjectTitle.AutoSize = true;
            this.lblScannedObjectTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblScannedObjectTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblScannedObjectTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblScannedObjectTitle.Location = new System.Drawing.Point(8, 13);
            this.lblScannedObjectTitle.Name = "lblScannedObjectTitle";
            this.lblScannedObjectTitle.Size = new System.Drawing.Size(93, 15);
            this.lblScannedObjectTitle.TabIndex = 4;
            this.lblScannedObjectTitle.Text = "Threat Object : ";
            // 
            // lblPluginInfo
            // 
            this.lblPluginInfo.AutoSize = true;
            this.lblPluginInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPluginInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPluginInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblPluginInfo.Location = new System.Drawing.Point(13, 71);
            this.lblPluginInfo.Name = "lblPluginInfo";
            this.lblPluginInfo.Size = new System.Drawing.Size(134, 19);
            this.lblPluginInfo.TabIndex = 1;
            this.lblPluginInfo.Text = "Plugin Information";
            // 
            // monoFlat_Panel1
            // 
            this.monoFlat_Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.monoFlat_Panel1.Controls.Add(this.lblPluginDescription);
            this.monoFlat_Panel1.Controls.Add(this.lblPluginNameAndVersion);
            this.monoFlat_Panel1.Location = new System.Drawing.Point(13, 98);
            this.monoFlat_Panel1.Name = "monoFlat_Panel1";
            this.monoFlat_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.monoFlat_Panel1.Size = new System.Drawing.Size(672, 66);
            this.monoFlat_Panel1.TabIndex = 3;
            this.monoFlat_Panel1.Text = "monoFlat_Panel1";
            // 
            // lblPluginDescription
            // 
            this.lblPluginDescription.AutoSize = true;
            this.lblPluginDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblPluginDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPluginDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblPluginDescription.Location = new System.Drawing.Point(8, 40);
            this.lblPluginDescription.Name = "lblPluginDescription";
            this.lblPluginDescription.Size = new System.Drawing.Size(71, 15);
            this.lblPluginDescription.TabIndex = 5;
            this.lblPluginDescription.Text = "Description";
            // 
            // lblPluginNameAndVersion
            // 
            this.lblPluginNameAndVersion.AutoSize = true;
            this.lblPluginNameAndVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblPluginNameAndVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPluginNameAndVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.lblPluginNameAndVersion.Location = new System.Drawing.Point(8, 13);
            this.lblPluginNameAndVersion.Name = "lblPluginNameAndVersion";
            this.lblPluginNameAndVersion.Size = new System.Drawing.Size(107, 15);
            this.lblPluginNameAndVersion.TabIndex = 4;
            this.lblPluginNameAndVersion.Text = "Name and version";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOk.Image = null;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(585, 405);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 41);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ThreatInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 458);
            this.Controls.Add(this.ThreatInfoTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThreatInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Threat Info";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ThreatInfoTheme.ResumeLayout(false);
            this.ThreatInfoTheme.PerformLayout();
            this.monoFlat_Panel2.ResumeLayout(false);
            this.monoFlat_Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRiskRate)).EndInit();
            this.monoFlat_Panel1.ResumeLayout(false);
            this.monoFlat_Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat_ThemeContainer ThreatInfoTheme;
        private MonoFlat_Button btnOk;
        private MonoFlat_Label lblThreatInfo;
        private MonoFlat_Panel monoFlat_Panel2;
        private MonoFlat_Label lblRiskRateTitle;
        private MonoFlat_Label lblScannedObjectTitle;
        private MonoFlat_Label lblPluginInfo;
        private MonoFlat_Panel monoFlat_Panel1;
        private MonoFlat_Label lblPluginDescription;
        private MonoFlat_Label lblPluginNameAndVersion;
        private MonoFlat_Label lblMessageTitle;
        private MonoFlat_Label lblThreatObject;
        private MonoFlat_Label lblRisk;
        private MonoFlat_Label lblMessage;
        private System.Windows.Forms.PictureBox pbRiskRate;
    }
}