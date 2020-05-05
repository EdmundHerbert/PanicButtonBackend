using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Haloinappmessages
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string MessageType { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int? MemberId { get; set; }
        public int? Read { get; set; }
        public int? Sent { get; set; }
        public DateTime? SentAt { get; set; }
        public DateTime? ReadAt { get; set; }
    }
}
