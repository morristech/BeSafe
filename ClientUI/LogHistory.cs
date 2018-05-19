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
            using (var logHistory = new LogHistory())
            {
                logHistory.LoadLogFromEventLog(DateTime.Now);
                return logHistory.ShowDialog() == DialogResult.OK;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadLogFromEventLog(dateTimePicker.Value);
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

        private void LoadLogFromEventLog(DateTime? dateTime)
        {
            LogPresenterList.Clear();

            EventLogEntryCollection applicationEntries = EventLog.GetEventLogs().FirstOrDefault(f => f.LogDisplayName == "Application").Entries;
            IEnumerable<EventLogEntry> beSafeLogEntries = applicationEntries.Cast<EventLogEntry>().Where(w => w.Source == Resources.ApplicationName && w.InstanceId == BeSafe_Log_EventID);

            List<EventLogEntry> beSafeLogsFilteredByDate = (dateTime != null) ? beSafeLogEntries.Where(w => w.TimeWritten.Date.CompareTo(dateTime.Value.Date) == 0).ToList() : beSafeLogEntries.ToList();

            foreach (EventLogEntry ev in beSafeLogsFilteredByDate)
            {
                if (!ev.Data.Any())
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

            logPresenterBindingSource.DataSource = LogPresenterList.ToList();
        }
    }
}