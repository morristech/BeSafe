using System;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using ClientUI.Properties;
using ClientUI.Core;
using PluginSDK;

namespace ClientUI
{
    public partial class LogHistory : Form
    {
        private const int BeSafe_Log_EventID = 2;
        private static List<LogPresenter> LogPresenterList = new List<LogPresenter>();

        public LogHistory()
        {
            InitializeComponent();
        }

        public static bool Execute()
        {
            EventLogEntryCollection applicationEntries = EventLog.GetEventLogs().FirstOrDefault(f => f.LogDisplayName == "Application").Entries;
            List<EventLogEntry> beSafeLogEntries = applicationEntries.Cast<EventLogEntry>().Where(w => w.Source == Resources.ApplicationName && w.InstanceId == BeSafe_Log_EventID).ToList();

            foreach (EventLogEntry ev in beSafeLogEntries)
            {
                if (! ev.Data.Any())
                    continue;

                PluginResult pluginResult = Deserialize<PluginResult>(ev.Data);

                LogPresenterList.Add(new LogPresenter
                {
                    Date = ev.TimeWritten,
                    ScannedObject = pluginResult.ScannedObjectString,
                    PluginName = pluginResult.PluginInfo.ToString(),
                    Risk = pluginResult.RiskRate,
                    PluginMessage = pluginResult.Message,
                });
            }

            using (var logHistory = new LogHistory())
            {
                logHistory.logPresenterBindingSource.DataSource = LogPresenterList;
                return logHistory.ShowDialog() == DialogResult.OK;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (CsvExportDialog.ShowDialog() != DialogResult.OK)
                return;

            List<string> csvFileContent = new List<string>();

            foreach(LogPresenter log in LogPresenterList)
            {
                csvFileContent.Add($"{log.Date},{log.ScannedObject},{log.Risk},{log.PluginName},{log.PluginMessage}".Replace(Environment.NewLine, ";"));
            }

            File.AppendAllLines(CsvExportDialog.FileName, csvFileContent);
            MessageBox.Show(Resources.ExportDoneMessage, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static T Deserialize<T>(byte[] param)
        {
            using (MemoryStream ms = new MemoryStream(param))
            {
                IFormatter br = new BinaryFormatter();
                return (T)br.Deserialize(ms);
            }
        }
    }
}