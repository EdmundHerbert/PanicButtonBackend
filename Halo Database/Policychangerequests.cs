using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Policychangerequests
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public string ChangeDetails { get; set; }
        public string PolicyId { get; set; }
        public string RiskItemId { get; set; }
        public DateTime RequestTimestamp { get; set; }
    }
}
