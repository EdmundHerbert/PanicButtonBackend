using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class ClientTokens
    {
        public string ClientId { get; set; }
        public int TokensAvailable { get; set; }
        public uint? TokensUsed { get; set; }
        public uint? TokensBrought { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
    }
}
