using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class ArchiveHalomemberprograms
    {
        public int ArchiveId { get; set; }
        public string HaloMemberProgramId { get; set; }
        public string HaloClientId { get; set; }
        public string HaloMemberId { get; set; }
        public string HaloProgramId { get; set; }
        public string DateDeleted { get; set; }
    }
}
