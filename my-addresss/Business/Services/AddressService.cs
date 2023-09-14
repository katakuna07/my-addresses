using System;
using my_addresss.Business.Services.Interfaces;
using my_addresss.Domain.Models;
using RestSharp;

namespace my_addresss.Business.Services
{
	public class AddressService : IAddressService
    {
        private readonly IConfiguration configuration;

        public AddressService(IConfiguration _configuration)
		{
            configuration = _configuration;
		}

        public async Task<Address> GetAddress(string cep)
        {
            var client = new RestClient();
            var uri = $"{configuration.GetValue<string>("CEP_API")}/{cep}";

            var response = await client.ExecuteAsync<Address>(new RestRequest(uri, Method.Get));

            return response.Data;
        }
    }
}

