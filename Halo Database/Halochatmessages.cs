using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Halochatmessages
    {
        public long HaloChatMessageId { get; set; }
        public long? HaloChatRequestId { get; set; }
        public string HaloChatMessage { get; set; }
        public long? HaloChatMessageSentFrom { get; set; }
        public long? HaloChatMessageSentTo { get; set; }
        public DateTime? HaloChatMessageSentAt { get; set; }
        public string HaloChatMessageType { get; set; }
    }
}
