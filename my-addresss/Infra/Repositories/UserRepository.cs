using System;
using my_addresss.Domain.Models;
using my_addresss.Helpers;
using my_addresss.Infra.Interfaces;

namespace my_addresss.Infra.Repositories
{
	public class UserRepository : IUserRepository
	{

        private DatabaseContext _dbContext;

		public UserRepository(DatabaseContext dbContext)
		{
            _dbContext = dbContext;
        }

        public async Task<bool> CreateUser(User user)
        {
             _dbContext.AddAsync(user);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<User> GetUser(string userLogin)
        {
            return _dbContext.Users.FirstOrDefault(u => u.login == userLogin);
        }

        public async Task<bool> UpdateUser(User user)
        {
            _dbContext.Update<User>(user);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}

