using System;

namespace ReservationHub.Core
{
    public class ReservationModel
    {
        public string Id { get; set; }
        public string Owner { get; set; }
        public string Address { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime ExpirationTime { get; set; }
    }
}
