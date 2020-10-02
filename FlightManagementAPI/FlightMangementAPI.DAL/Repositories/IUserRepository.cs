using FlightMangementAPI.DAL.Models;

namespace FlightMangementAPI.DAL.Repositories
{
    public interface IUserRepository
    {
        User ValidateUser(string email, string password);
    }
}
