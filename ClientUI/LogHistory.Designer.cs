namespace ClientUI
{
    partial class LogHistory
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
            this.monoFlat_ThemeContainer1 = new ClientUI.MonoFlat_ThemeContainer();
            this.btnExport = new ClientUI.MonoFlat_Button();
            this.btnOk = new ClientUI.MonoFlat_Button();
            this.LogsGrid = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluginNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scannedObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluginMessageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logPresenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monoFlat_ThemeContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPresenterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnExport);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btnOk);
            this.monoFlat_ThemeContainer1.Controls.Add(this.LogsGrid);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(1375, 784);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "Log History";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExport.Image = null;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(1116, 732);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 41);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOk.Image = null;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(1242, 732);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(120, 41);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // LogsGrid
            // 
            this.LogsGrid.AllowUserToAddRows = false;
            this.LogsGrid.AllowUserToDeleteRows = false;
            this.LogsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogsGrid.AutoGenerateColumns = false;
            this.LogsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.LogsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.pluginNameDataGridViewTextBoxColumn,
            this.scannedObjectDataGridViewTextBoxColumn,
            this.pluginMessageDataGridViewTextBoxColumn,
            this.riskDataGridViewTextBoxColumn});
            this.LogsGrid.DataSource = this.logPresenterBindingSource;
            this.LogsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.LogsGrid.Location = new System.Drawing.Point(12, 73);
            this.LogsGrid.Name = "LogsGrid";
            this.LogsGrid.ReadOnly = true;
            this.LogsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LogsGrid.Size = new System.Drawing.Size(1350, 649);
            this.LogsGrid.TabIndex = 0;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 120F;
            this.dateDataGridViewTextBoxColumn.Frozen = true;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 140;
            // 
            // pluginNameDataGridViewTextBoxColumn
            // 
            this.pluginNameDataGridViewTextBoxColumn.DataPropertyName = "PluginName";
            this.pluginNameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.pluginNameDataGridViewTextBoxColumn.HeaderText = "PluginName";
            this.pluginNameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.pluginNameDataGridViewTextBoxColumn.Name = "pluginNameDataGridViewTextBoxColumn";
            this.pluginNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pluginNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // scannedObjectDataGridViewTextBoxColumn
            // 
            this.scannedObjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.scannedObjectDataGridViewTextBoxColumn.DataPropertyName = "ScannedObject";
            this.scannedObjectDataGridViewTextBoxColumn.HeaderText = "ScannedObject";
            this.scannedObjectDataGridViewTextBoxColumn.Name = "scannedObjectDataGridViewTextBoxColumn";
            this.scannedObjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pluginMessageDataGridViewTextBoxColumn
            // 
            this.pluginMessageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pluginMessageDataGridViewTextBoxColumn.DataPropertyName = "PluginMessage";
            this.pluginMessageDataGridViewTextBoxColumn.HeaderText = "PluginMessage";
            this.pluginMessageDataGridViewTextBoxColumn.Name = "pluginMessageDataGridViewTextBoxColumn";
            this.pluginMessageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // riskDataGridViewTextBoxColumn
            // 
            this.riskDataGridViewTextBoxColumn.DataPropertyName = "Risk";
            this.riskDataGridViewTextBoxColumn.HeaderText = "Risk";
            this.riskDataGridViewTextBoxColumn.Name = "riskDataGridViewTextBoxColumn";
            this.riskDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logPresenterBindingSource
            // 
            this.logPresenterBindingSource.DataSource = typeof(ClientUI.Core.LogPresenter);
            // 
            // LogHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 784);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log History";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPresenterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private System.Windows.Forms.DataGridView LogsGrid;
        private System.Windows.Forms.BindingSource logPresenterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pluginNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scannedObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pluginMessageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riskDataGridViewTextBoxColumn;
        private MonoFlat_Button btnExport;
        private MonoFlat_Button btnOk;
    }
}