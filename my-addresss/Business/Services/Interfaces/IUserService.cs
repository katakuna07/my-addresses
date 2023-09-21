using System;
using my_addresss.Domain.Models;

namespace my_addresss.Business.Services.Interfaces
{
	public interface IUserService
	{
		Task<User> GetUser(string userLogin);
		Task<bool> CreateUser(User user);
		Task<bool> UpdateUser(User user);
	}
}

