using NUnit.Framework;
using ReservationHub.Core;
using Shouldly;

namespace ReservationHub.UnitTests
{
    [TestFixture]
    public class ReservationManagerShould
    {
        [TestCase(3)]
        public void Book_A_Given_Amount_Of_Reserves(int numberOfReservations)
        {
            var reservationManager = new ReservationManager();

            reservationManager.Book(numberOfReservations);

            var reservations = reservationManager.Reservations().Count;

            reservations.ShouldBe(numberOfReservations);
        }
    }
}
