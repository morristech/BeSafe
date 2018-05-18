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

        public LogHistory()
        {
            InitializeComponent();
        }

        public static bool Execute()
        {
            var logPresenter = new List<LogPresenter>();

            EventLogEntryCollection applicationEntries = EventLog.GetEventLogs().FirstOrDefault(f => f.LogDisplayName == "Application").Entries;
            List<EventLogEntry> beSafeLogEntries = applicationEntries.Cast<EventLogEntry>().Where(w => w.Source == Resources.ApplicationName && w.InstanceId == BeSafe_Log_EventID).ToList();

            foreach (EventLogEntry ev in beSafeLogEntries)
            {
                if (! ev.Data.Any())
                    continue;

                PluginResult pluginResult = Deserialize<PluginResult>(ev.Data);

                logPresenter.Add(new LogPresenter
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
                logHistory.logPresenterBindingSource.DataSource = logPresenter;
                return logHistory.ShowDialog() == DialogResult.OK;
            }
        }

        private static T Deserialize<T>(byte[] param)
        {
            using (MemoryStream ms = new MemoryStream(param))
            {
                IFormatter br = new BinaryFormatter();
                return (T)br.Deserialize(ms);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}