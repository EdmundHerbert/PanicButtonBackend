using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Halomembermessages
    {
        public long HaloMemberMessageId { get; set; }
        public string HaloMemberMessage { get; set; }
        public long? HaloMemberMessageSentFromId { get; set; }
        public string HaloMemberMessageSentFromName { get; set; }
        public long? HaloMemberMessageSentTo { get; set; }
        public bool? HaloMemberMessageRead { get; set; }
        public DateTime? HaloMemberMessageSentAt { get; set; }
        public bool? HaloMemberMessageDeleted { get; set; }
    }
}
