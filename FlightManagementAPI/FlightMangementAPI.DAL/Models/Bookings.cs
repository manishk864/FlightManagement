using System.ComponentModel.DataAnnotations.Schema;

namespace FlightMangementAPI.DAL.Models
{
    public class Bookings
    {
        public int Id { get; set; }

        public int OrderNumber { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }

        [ForeignKey("Flight")]
        public int FlightId { get; set; }

        public string Email { get; set; }

        public string CustomerName { get; set; }

        public int NumberOfSeats { get; set; }

        public int UnitPrice { get; set; }

        public int Taxes { get; set; }

    }
}
