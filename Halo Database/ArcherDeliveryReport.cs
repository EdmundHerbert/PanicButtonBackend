using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class ArcherDeliveryReport
    {
        public string MessageId { get; set; }
        public string DeliveryId { get; set; }
        public string Msisdn { get; set; }
        public int? StatusCode { get; set; }
        public string Description { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Json { get; set; }
        public int? Processed { get; set; }
    }
}
