using NUnit.Framework;
using ReservationHub.Core;
using Shouldly;
using System.Linq;

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

        [TestCase(3, "Juanjo Cerezuela", "1 Kingsway")]
        [TestCase(5, "Tony Stark", "Avengers Base")]
        public void Book_A_Given_Amount_Of_Reserves_With_Properties(int numberOfReservations, string owner, string address)
        {
            var reservationManager = new ReservationManager();

            reservationManager.Book(numberOfReservations, owner, address);

            var reservations = reservationManager.Reservations().Count;
            var expectedOwner = reservationManager.Reservations().First().Owner;
            var expectedAddress = reservationManager.Reservations().First().Address;

            expectedOwner.ShouldBe(owner);
            expectedOwner.ShouldBe(address);
        }
    }
}
