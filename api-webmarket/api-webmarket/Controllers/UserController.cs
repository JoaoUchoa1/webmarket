using api_webmarket.Domain.Models;
using api_webmarket.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Controllers
{
    [Route("/api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetAllAsync() 
        {
            var users = await _userService.ListAsync();
            return users;
        }
    }
}
