using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Otplogin
    {
        public int Id { get; set; }
        public string OtpCode { get; set; }
        public int OtpType { get; set; }
        public DateTime? CreatedDateUtc { get; set; }
        public int UserType { get; set; }
        public int UserId { get; set; }
        public int? ClientId { get; set; }
        public string TenantId { get; set; }
        public string UserKey { get; set; }
        public int? NotificationType { get; set; }
        public int? IsValid { get; set; }
    }
}
