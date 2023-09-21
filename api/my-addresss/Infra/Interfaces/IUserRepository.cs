using System;
using my_addresss.Domain.Models;

namespace my_addresss.Infra.Interfaces
{
	public interface IUserRepository
	{
        Task<bool> CreateUser(User user);
        Task<User> GetUser(string userLogin);
        Task<bool> UpdateUser(User user);
    }
}

