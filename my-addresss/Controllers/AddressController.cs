using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_addresss.Business.Services.Interfaces;
using my_addresss.Domain.Models;

namespace my_addresss.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService addressService;

        public AddressController(IAddressService _addressService)
        {
            addressService = _addressService;
        }

        [HttpGet(Name = "GetAddress")]
        public Task<Address> GetAddress(string cep)
        {
            return addressService.GetAddress(cep);
        }
    }
}

