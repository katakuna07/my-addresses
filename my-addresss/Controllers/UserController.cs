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
        private readonly IUserInterface userInterface;

        public UserController(IUserInterface _userService)
        {
            userInterface = _userService;
        }

        [HttpGet(Name = "User"), Authorize]
        public Task<User> GetUser()
        {
            return userInterface.GetUser();
        }

        [HttpPost(Name = "User"), Authorize]
        public Task<bool> CreateUser(User user)
        {
            return userInterface.CreateUser(user);
        }

        [HttpPut(Name = "User"), Authorize]
        public Task<bool> UpdateUser(User user)
        {
            return userInterface.UpdateUser(user);
        }
    }
}

