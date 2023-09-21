using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using my_addresss.Business.Services.Interfaces;
using my_addresss.Domain.Models;

namespace my_addresss.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet(Name = "User")]
        public Task<User> GetUser(string userLogin)
        {
            return _userService.GetUser(userLogin);
        }

        [HttpPost(Name = "User")]
        public Task<bool> CreateUser(User user)
        {
            return _userService.CreateUser(user);
        }

        [HttpPut(Name = "User")]
        public Task<bool> UpdateUser(User user)
        {
            return _userService.UpdateUser(user);
        }
    }
}

