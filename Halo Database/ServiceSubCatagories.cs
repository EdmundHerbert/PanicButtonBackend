using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class ServiceSubCatagories
    {
        public int ServiceSubCatagorieId { get; set; }
        public int? ServiceCatagorieId { get; set; }
        public string ServiceSubCatagorieName { get; set; }
        public string ServiceSubCatagorieDescription { get; set; }
    }
}
