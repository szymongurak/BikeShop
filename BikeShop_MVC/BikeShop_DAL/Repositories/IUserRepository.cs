using BikeShop_DAL.Models;

namespace BikeShop_DAL.Repositories
{
    public interface IUserRepository
    {
        User GetUserById(string userId);
    }
}
