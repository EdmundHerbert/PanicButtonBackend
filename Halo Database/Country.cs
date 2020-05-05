using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public int? ServiceSubCatagorieId { get; set; }
        public string CountryName { get; set; }
        public string CountryDescription { get; set; }
    }
}
