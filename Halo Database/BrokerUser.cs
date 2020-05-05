using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class BrokerUser
    {
        public int Id { get; set; }
        public string TenantId { get; set; }
        public int ClientId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Secret { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? ModifiedOnUtc { get; set; }
        public string MobileNumber { get; set; }
        public ulong? IsActive { get; set; }
    }
}
