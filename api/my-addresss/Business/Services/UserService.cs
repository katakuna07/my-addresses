using System;
using my_addresss.Business.Services.Interfaces;
using my_addresss.Domain.Models;
using my_addresss.Infra.Interfaces;

namespace my_addresss.Business.Services
{
	public class UserService : IUserService
	{
        private IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<bool> CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        public Task<User> GetUser(string userLogin)
        {
            return _userRepository.GetUser(userLogin);
        }

        public Task<bool> UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}

