using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Token
    {
        public int AutoInc { get; set; }
        public string Id { get; set; }
        public string Issuer { get; set; }
        public string UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
