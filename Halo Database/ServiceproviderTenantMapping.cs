using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class ServiceproviderTenantMapping
    {
        public int Id { get; set; }
        public string Tenant { get; set; }
        public int TenantId { get; set; }
        public int? ServiceproviderId { get; set; }
        public ulong? IsPreferred { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        public virtual Serviceprovider Serviceprovider { get; set; }
        public virtual Tenant TenantNavigation { get; set; }
    }
}
