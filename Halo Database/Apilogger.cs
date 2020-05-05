using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Apilogger
    {
        public long LoggerId { get; set; }
        public string LoggerApi { get; set; }
        public string Apikey { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Host { get; set; }
        public string Protocol { get; set; }
        public string Method { get; set; }
        public string Path { get; set; }
        public string ContentType { get; set; }
        public string Scheme { get; set; }
        public string QueryString { get; set; }
        public string IsHttps { get; set; }
        public string RemoteIpAddress { get; set; }
    }
}
