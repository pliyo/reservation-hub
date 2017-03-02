using System;

namespace ReservationHub.Models
{
    public class ReservationModel
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public string Address { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
