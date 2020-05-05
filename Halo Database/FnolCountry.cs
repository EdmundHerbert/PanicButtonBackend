using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class FnolCountry
    {
        public FnolCountry()
        {
            Address = new HashSet<Address>();
            FnolCity = new HashSet<FnolCity>();
            FnolStateprovince = new HashSet<FnolStateprovince>();
            FnolSuburb = new HashSet<FnolSuburb>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string TwoLetterIsoCode { get; set; }
        public string ThreeLetterIsoCode { get; set; }
        public int NumericIsoCode { get; set; }
        public int Published { get; set; }
        public int DisplayOrder { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<FnolCity> FnolCity { get; set; }
        public virtual ICollection<FnolStateprovince> FnolStateprovince { get; set; }
        public virtual ICollection<FnolSuburb> FnolSuburb { get; set; }
    }
}
