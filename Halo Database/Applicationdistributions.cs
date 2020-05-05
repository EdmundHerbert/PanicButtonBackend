using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Applicationdistributions
    {
        public int DistroId { get; set; }
        public string DistroNamespace { get; set; }
        public string DistroTitle { get; set; }
        public string DistroJson { get; set; }
        public int ClientId { get; set; }
    }
}
