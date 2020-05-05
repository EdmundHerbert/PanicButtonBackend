using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class ServiceProvidersAudit
    {
        public int ServiceProvidersAuditId { get; set; }
        public string ServiceProvidersAuditUserName { get; set; }
        public string ServiceProvidersAuditType { get; set; }
        public string ServiceProvidersAuditChangeDate { get; set; }
        public string ServiceProvidersAuditChangedTableName { get; set; }
        public string ServiceProvidersAuditData { get; set; }
    }
}
