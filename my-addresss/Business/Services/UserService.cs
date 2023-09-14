using System;
using my_addresss.Business.Services.Interfaces;
using my_addresss.Domain.Models;

namespace my_addresss.Business.Services
{
	public class UserService : IUserInterface
	{
		public UserService() { }

        public Task<bool> CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}

