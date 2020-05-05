using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Serviceprovidercategory
    {
        public int Id { get; set; }
        public int ServiceProviderId { get; set; }
        public int CategoryId { get; set; }
        public int IsFeaturedProduct { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Category Category { get; set; }
        public virtual Serviceprovider ServiceProvider { get; set; }
    }
}
