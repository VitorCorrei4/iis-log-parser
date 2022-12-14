using System;
using System.Collections.Generic;
using System.Text;

namespace IISLogParser
{
    public class IISLogEvent
    {
        public DateTime DateTimeEvent { get; set; }
        public string sSitename { get; set; }
        public string sComputername { get; set; }
        public string sIp { get; set; }
        public string csMethod { get; set; }
        public string csUriStem { get; set; }
        public string csUriQuery { get; set; }
        public int? sPort { get; set; }
        public string csUsername { get; set; }
        public string cIp { get; set; }
        public string csVersion { get; set; }
        public string csUserAgent { get; set; }
        public string csCookie { get; set; }
        public string csReferer { get; set; }
        public string csHost { get; set; }
        public int? scStatus { get; set; }
        public int? scSubstatus { get; set; }
        public long? scWin32Status { get; set; }
        public int? scBytes { get; set; }
        public int? csBytes { get; set; }
        public int? timeTaken { get; set; }
    }
}
