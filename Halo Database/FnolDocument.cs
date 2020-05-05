using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class FnolDocument
    {
        public int Id { get; set; }
        public string UniqueId { get; set; }
        public string ReferenceNumber { get; set; }
        public byte[] Base64Content { get; set; }
        public string MimeType { get; set; }
        public int? Size { get; set; }
        public string Name { get; set; }
        public string PolicyNumber { get; set; }
    }
}
