using System;
using System.Collections.Generic;

namespace PanicButtonBackend
{
    public partial class Inappnotificationclientdetails
    {
        public int Id { get; set; }
        public string AppId { get; set; }
        public string OnesignalToken { get; set; }
        public string UserId { get; set; }
        public string ClientId { get; set; }
        public string NotificationTitle { get; set; }
        public string HaloClientId { get; set; }
    }
}
