using System.Linq;
using System.Collections.Generic;
using VirusTotalNET.Results;
using SharedTypes.Watchers;

namespace BeSafe.Components.Engines
{
    public class VirusTotalEngine
    {
        private readonly string _apiKey;
        private readonly VirusTotalNET.VirusTotal _virusTotal;

        public VirusTotalEngine(string apiKey)
        {
            _apiKey = apiKey;
            _virusTotal = new VirusTotalNET.VirusTotal(apiKey) { UseTLS = true };
        }

        public List<FileReport> ScanProcess(List<ProcessInfo> processInfos)
        {
            List<string> processHashList = processInfos.Select(s => s.Sha256Hash).ToList();
            return _virusTotal.GetFileReportsAsync(processHashList).Result.ToList();
        }

        public List<FileReport> ScanModule(List<ModuleInfo> moduleInfos)
        {
            List<string> moduleHashList = moduleInfos.Select(s => s.Sha256Hash).ToList();
            return _virusTotal.GetFileReportsAsync(moduleHashList).Result.ToList();
        }

        public List<UrlReport> ScanURL(List<string> urlList)
        {
            return _virusTotal.GetUrlReportsAsync(urlList).Result.ToList();
        }
    }
}