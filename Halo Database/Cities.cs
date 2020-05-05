using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Cities
    {
        public int CityId { get; set; }
        public int? RegionId { get; set; }
        public string CityName { get; set; }
        public string CityDescription { get; set; }
    }
}
