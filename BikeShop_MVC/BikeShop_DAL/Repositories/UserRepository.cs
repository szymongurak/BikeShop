using System;
using System.Collections.Generic;
using System.Text;
using BikeShop_DAL.Models;
using BikeShop_DAL.Data;
namespace BikeShop_DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext; 
        }

        public User GetUserById(string userId)
        {
            return _applicationDbContext.Users
                .Find(userId);
        }
    }
}
