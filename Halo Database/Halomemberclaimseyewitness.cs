using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Halomemberclaimseyewitness
    {
        public long HaloMemberClaimsEyewitnessId { get; set; }
        public long? HaloMemberClaimsId { get; set; }
        public string HaloMemberClaimsEyewitnessName { get; set; }
        public string HaloMemberClaimsEyewitnessContact { get; set; }
        public string HaloMemberClaimsEyewitnessAddress { get; set; }

        public virtual Halomemberclaims HaloMemberClaims { get; set; }
    }
}
