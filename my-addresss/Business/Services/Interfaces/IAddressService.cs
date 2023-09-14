using System;
using my_addresss.Domain.Models;

namespace my_addresss.Business.Services.Interfaces
{

	public interface IAddressService
	{
        Task<Address> GetAddress(string cep);
	}
}

