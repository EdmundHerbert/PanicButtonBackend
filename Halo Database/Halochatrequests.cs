using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Halochatrequests
    {
        public long HaloChatRequestId { get; set; }
        public long? HaloChatRequestMemberId { get; set; }
        public string HaloChatRequestMemberPhoneNumber { get; set; }
        public bool? HaloChatRequestActive { get; set; }
        public DateTime? HaloChatRequestTimeStamp { get; set; }
        public DateTime? HaloChatRequestLastTransaction { get; set; }
        public long? HaloChatRequestHandledBy { get; set; }
        public string HaloChatRequestHandledAt { get; set; }
        public string HaloChatRequestLatitude { get; set; }
        public string HaloChatRequestLongitude { get; set; }
        public bool? HaloChatRequestHasUnread { get; set; }
    }
}
