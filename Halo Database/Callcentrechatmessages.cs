using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Callcentrechatmessages
    {
        public long CallCentreChatMessageId { get; set; }
        public string CallCentreChatMessage { get; set; }
        public long? CallCentreChatMessageSentFrom { get; set; }
        public long? CallCentreChatMessageSentTo { get; set; }
        public bool? CallCentreChatMessageRead { get; set; }
        public DateTime? CallCentreChatMessageSentAt { get; set; }
    }
}
