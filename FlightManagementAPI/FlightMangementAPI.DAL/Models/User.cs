using System.ComponentModel.DataAnnotations;

namespace FlightMangementAPI.DAL.Models
{
    public class User
    {
        public int Id { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }
    }
}
