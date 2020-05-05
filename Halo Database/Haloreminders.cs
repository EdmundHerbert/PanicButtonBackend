using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Haloreminders
    {
        public long Id { get; set; }
        public int? ReminderType { get; set; }
        public string ReferenceNumber { get; set; }
        public long? InAppMessageId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
