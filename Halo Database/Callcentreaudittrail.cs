using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Callcentreaudittrail
    {
        public long CallCentreAuditTrailId { get; set; }
        public long? CallCentreAuditTrailUserId { get; set; }
        public string CallCentreAuditTrailTransaction { get; set; }
        public DateTime? CallCentreAuditTrailDate { get; set; }
    }
}
