using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Serviceprovideraddress
    {
        public int Id { get; set; }
        public int ServiceProviderId { get; set; }
        public int AddressId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Address Address { get; set; }
        public virtual Serviceprovider ServiceProvider { get; set; }
    }
}
