using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Halopanics
    {
        public long HaloPanicId { get; set; }
        public long? HaloMemberId { get; set; }
        public string HaloMemberPhoneNumber { get; set; }
        public string HaloPanicLatitude { get; set; }
        public string HaloPanicLongitude { get; set; }
        public bool? HaloPanicActive { get; set; }
        public DateTime? HaloPanicTimeStamp { get; set; }
        public long? HaloPanicHandledBy { get; set; }
        public DateTime? HaloPanicHandledAt { get; set; }
        public long? HaloPanicProductId { get; set; }
        public long? HaloPanicVmiId { get; set; }
        public string HaloCaseId { get; set; }
    }
}
