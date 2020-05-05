using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Halosentsmss
    {
        public long HaloSentSmsid { get; set; }
        public long? HaloSentSmsfromId { get; set; }
        public long? HaloSentSmstoId { get; set; }
        public string HaloSentSmsmessage { get; set; }
        public DateTime? HaloSentSmstimeStamp { get; set; }
        public string HaloSentSmsgatewayResponse { get; set; }
    }
}
