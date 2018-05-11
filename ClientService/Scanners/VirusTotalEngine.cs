using System.Linq;
using System.Collections.Generic;
using VirusTotalNET.Results;

namespace BeSafe.Scanners
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

        public List<FileReport> ScanFile(List<string> Objecthash)
        {
            return virusTotal.GetFileReportsAsync(Objecthash).Result.ToList();
        }

        public List<UrlReport> ScanURL(List<string> urlList)
        {
            return virusTotal.GetUrlReportsAsync(urlList).Result.ToList();
        }
    }
}