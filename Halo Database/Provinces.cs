﻿using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Provinces
    {
        public int ProvinceId { get; set; }
        public int? CountryId { get; set; }
        public string ProvinceName { get; set; }
        public string ProvinceDescription { get; set; }
        public string Provincescol { get; set; }
    }
}
