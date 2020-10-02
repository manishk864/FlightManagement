using FlightMangementAPI.DAL.Models;
using System.Linq;

namespace FlightMangementAPI.DAL.Repositories
{
    public class UserRepository<T> : BaseRepository<T>, IUserRepository  where T:class
    {
        private readonly FlightDbContext _context;

        public UserRepository(FlightDbContext context) : base(context)
        {
            _context = context;
        }

        public User ValidateUser(string email, string password)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email && x.Password == password); // encrypt the password before comparing
        }
    }
}
