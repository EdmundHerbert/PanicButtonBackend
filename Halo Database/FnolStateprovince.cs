using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class FnolStateprovince
    {
        public FnolStateprovince()
        {
            Address = new HashSet<Address>();
            FnolCity = new HashSet<FnolCity>();
            FnolSuburb = new HashSet<FnolSuburb>();
        }

        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int Published { get; set; }
        public int DisplayOrder { get; set; }

        public virtual FnolCountry Country { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<FnolCity> FnolCity { get; set; }
        public virtual ICollection<FnolSuburb> FnolSuburb { get; set; }
    }
}
