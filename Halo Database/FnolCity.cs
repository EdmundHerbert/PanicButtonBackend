using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class FnolCity
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int StateProvinceId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int Published { get; set; }
        public int DisplayOrder { get; set; }

        public virtual FnolCountry Country { get; set; }
        public virtual FnolStateprovince StateProvince { get; set; }
    }
}
