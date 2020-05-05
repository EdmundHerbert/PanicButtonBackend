using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Address
    {
        public Address()
        {
            ServiceproviderBillingAddress = new HashSet<Serviceprovider>();
            ServiceproviderPhysicalAddress = new HashSet<Serviceprovider>();
            Serviceprovideraddress = new HashSet<Serviceprovideraddress>();
        }

        public int Id { get; set; }
        public int? CountryId { get; set; }
        public int? StateProvinceId { get; set; }
        public string City { get; set; }
        public string Suburb { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipPostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string CreatedOnUtc { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int? ServiceProviderId { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public int? CityId { get; set; }
        public int? SuburbId { get; set; }

        public virtual FnolCountry Country { get; set; }
        public virtual Serviceprovider ServiceProvider { get; set; }
        public virtual FnolStateprovince StateProvince { get; set; }
        public virtual ICollection<Serviceprovider> ServiceproviderBillingAddress { get; set; }
        public virtual ICollection<Serviceprovider> ServiceproviderPhysicalAddress { get; set; }
        public virtual ICollection<Serviceprovideraddress> Serviceprovideraddress { get; set; }
    }
}
