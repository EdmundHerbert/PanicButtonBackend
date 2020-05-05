using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Serviceprovider
    {
        public Serviceprovider()
        {
            Address = new HashSet<Address>();
            ServiceproviderTenantMapping = new HashSet<ServiceproviderTenantMapping>();
            Serviceprovideraddress = new HashSet<Serviceprovideraddress>();
            Serviceprovidercategory = new HashSet<Serviceprovidercategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string RegisteredBusinessName { get; set; }
        public string TradingBusinessName { get; set; }
        public string IncomeTaxNumber { get; set; }
        public string VatNumber { get; set; }
        public string WebSite { get; set; }
        public string OwnersName { get; set; }
        public string Telephone { get; set; }
        public string CompanyEmail { get; set; }
        public string ContactPersonName { get; set; }
        public string CreatedOnUtc { get; set; }
        public string UpdatedOnUtc { get; set; }
        public int Active { get; set; }
        public int Deleted { get; set; }
        public int? BillingAddressId { get; set; }
        public int? PhysicalAddressId { get; set; }
        public int? SystemDefault { get; set; }

        public virtual Address BillingAddress { get; set; }
        public virtual Address PhysicalAddress { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<ServiceproviderTenantMapping> ServiceproviderTenantMapping { get; set; }
        public virtual ICollection<Serviceprovideraddress> Serviceprovideraddress { get; set; }
        public virtual ICollection<Serviceprovidercategory> Serviceprovidercategory { get; set; }
    }
}
