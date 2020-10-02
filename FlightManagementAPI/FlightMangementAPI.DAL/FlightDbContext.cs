using FlightMangementAPI.DAL.Models;
using System.Data.Entity;

namespace FlightMangementAPI.DAL
{
    public class FlightDbContext : DbContext
    {
        public FlightDbContext()
        {

        }

        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
