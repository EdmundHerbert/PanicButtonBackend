using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class RefreshToken
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string AuthTokenId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int? Revoked { get; set; }
    }
}
