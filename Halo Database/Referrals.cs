using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Referrals
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Relationship { get; set; }
        public int? ClientId { get; set; }
        public long? MemberId { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
