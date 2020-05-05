using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class ArchiveHalovehiclelicences
    {
        public int ArchiveId { get; set; }
        public string HaloVehicleLicenceId { get; set; }
        public string HaloMemberId { get; set; }
        public string HaloDependantId { get; set; }
        public string ControlNumber { get; set; }
        public string LicenceNumber { get; set; }
        public string RegisterNumber { get; set; }
        public string VehicleDescription { get; set; }
        public string VehicleMake { get; set; }
        public string SeriesName { get; set; }
        public string VehicleColour { get; set; }
        public string VinNumber { get; set; }
        public string EngineNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string VehicleYear { get; set; }
        public string DateDeleted { get; set; }
    }
}
