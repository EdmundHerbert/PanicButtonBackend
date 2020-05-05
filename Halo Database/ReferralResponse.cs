using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class ReferralResponse
    {
        public int Id { get; set; }
        public string HttpResponse { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
