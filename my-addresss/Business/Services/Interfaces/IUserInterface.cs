using System;
using my_addresss.Domain.Models;

namespace my_addresss.Business.Services.Interfaces
{
	public interface IUserInterface
	{
		Task<User> GetUser();
		Task<bool> CreateUser(User user);
		Task<bool> UpdateUser(User user);
	}
}

