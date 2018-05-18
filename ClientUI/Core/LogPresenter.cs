using System;
using PluginSDK;

namespace ClientUI.Core
{
    public class LogPresenter
    {
        public DateTime Date { get; set; }
        public string PluginName { get; set; }
        public string ScannedObject { get; set; }
        public string PluginMessage { get; set; }
        public ThreatRiskRates Risk { get; set; }
    }
}