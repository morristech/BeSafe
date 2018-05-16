using System;
using System.Windows.Forms;
using ClientUI.Properties;
using PluginSDK;

namespace ClientUI
{
    public partial class ThreatInfo : Form
    {
        public ThreatInfo()
        {
            InitializeComponent();
        }

        public static bool Execute(PluginResult pluginResult)
        {
            if (pluginResult == null)
                return false;

            using (var threatInfoForm = new ThreatInfo())
            {
                threatInfoForm.lblPluginNameAndVersion.Text = $"{pluginResult.PluginInfo.Name} {pluginResult.PluginInfo.Version}";
                threatInfoForm.lblPluginDescription.Text = pluginResult.PluginInfo.Description;
                threatInfoForm.lblThreatObject.Text = pluginResult.ScannedObjectString;
                threatInfoForm.lblRisk.Text = pluginResult.RiskRate.ToString();
                threatInfoForm.lblMessage.Text = pluginResult.Message;
                threatInfoForm.pbRiskRate.Image = pluginResult.RiskRate == ThreatRiskRates.HighRisk ? Resources.warning___red : Resources.warning___yellow;
                return threatInfoForm.ShowDialog() == DialogResult.OK;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}