using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class FnolClaim
    {
        public int Id { get; set; }
        public string UniqueId { get; set; }
        public string ReferenceNumber { get; set; }
        public string JsonContent { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        public DateTime? SubmittedOnUtc { get; set; }
        public int? Deleted { get; set; }
        public string TenantId { get; set; }
        public int ClientId { get; set; }
        public string SubmittedByEntityType { get; set; }
        public int? EntityId { get; set; }
        public string PolicyNumber { get; set; }
    }
}
