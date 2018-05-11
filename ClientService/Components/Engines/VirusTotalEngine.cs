using System.Linq;
using System.Collections.Generic;
using VirusTotalNET.Results;
using BeSafe.Components.Watchers.Types;

namespace BeSafe.Components.Engines
{
    public class VirusTotalEngine
    {
        private readonly string _apiKey;
        private VirusTotalNET.VirusTotal virusTotal;

        public VirusTotalEngine(string apiKey)
        {
            _apiKey = apiKey;
            virusTotal = new VirusTotalNET.VirusTotal(apiKey) { UseTLS = true };
        }

        public List<FileReport> ScanProcess(List<ProcessInfo> processInfos)
        {
            List<string> processHashList = processInfos.Select(s => s.Sha256Hash).ToList();
            return virusTotal.GetFileReportsAsync(processHashList).Result.ToList();
        }

        public List<FileReport> ScanModule(List<ModuleInfo> moduleInfos)
        {
            List<string> moduleHashList = moduleInfos.Select(s => s.Sha256Hash).ToList();
            return virusTotal.GetFileReportsAsync(moduleHashList).Result.ToList();
        }

        public List<UrlReport> ScanURL(List<string> urlList)
        {
            return virusTotal.GetUrlReportsAsync(urlList).Result.ToList();
        }
    }
}