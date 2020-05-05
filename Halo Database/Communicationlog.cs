using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Communicationlog
    {
        public int Id { get; set; }
        public DateTime SentAt { get; set; }
        public string Body { get; set; }
    }
}
