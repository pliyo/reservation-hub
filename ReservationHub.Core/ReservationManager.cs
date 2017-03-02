using System;
using System.Collections.Generic;

namespace ReservationHub.Core
{
    public class ReservationManager
    {
        private List<ReservationModel> _reservations;

        public ReservationManager()
        {
            _reservations = new List<ReservationModel>();
        }

        public void Book(int numberOfReservations)
        {
            for (int i = 0; i < numberOfReservations; i++)
            {
                _reservations.Add(new ReservationModel()
                {
                    Id = Guid.NewGuid().ToString(),
                    Address = "Hardcoded Address",
                    Owner = "Hardcoded Owner",
                    RequestDate = DateTime.Now
                });
            }
        }

        public List<ReservationModel> Reservations()
        {
            return _reservations;
        }
    }
}
