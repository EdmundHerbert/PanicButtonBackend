using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Tenant
    {
        public Tenant()
        {
            ServiceproviderTenantMapping = new HashSet<ServiceproviderTenantMapping>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public string TenantId { get; set; }
        public string Name { get; set; }
        public string HostNames { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
        public int IsEnabled { get; set; }
        public int Subscription { get; set; }
        public int? SubscriptionType { get; set; }
        public DateTime SubscriptionExipreDate { get; set; }
        public string DbConnectionString { get; set; }
        public string Theme { get; set; }
        public int? ClientId { get; set; }
        public string ClientCode { get; set; }
        public string Logo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string DataKey { get; set; }
        public int? ParentItemId { get; set; }

        public virtual ICollection<ServiceproviderTenantMapping> ServiceproviderTenantMapping { get; set; }
    }
}
