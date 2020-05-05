using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Haloaudittrail
    {
        public long HaloAuditTrailId { get; set; }
        public string HaloAuditTrailUserId { get; set; }
        public string HaloAuditTrailTransaction { get; set; }
        public string HaloAuditTrailStatus { get; set; }
        public DateTime? HaloAuditDate { get; set; }
    }
}
