using System;

namespace FlightMangementAPI.DAL.Models
{
    public class Flight
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string Company { get; set; }

        public int SeatCount { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public Decimal TicketPrice { get; set; }

        public DateTime DateOfDeparture { get; set; }

        public DateTime DateOfArrival { get; set; }
    }
}
