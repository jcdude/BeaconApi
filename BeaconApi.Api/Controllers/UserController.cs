using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeaconApi.Core.Services;
using BeaconApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeaconApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        public UserController(ApplicationDbContext applicationDbContext, IUserService userService) : base(applicationDbContext)
        {
            _userService = userService;
        }

        [HttpGet("{username}/{password}")]
        public ActionResult<string> GetToken(string username, string password)
        {
            
        }

        [HttpGet("{token}")]
        public ActionResult<string> CheckToken(string token)
        {
            var userData = from user in _applicationDbContext.Users
                           where user.token == token
                           select user;
            return userData.FirstOrDefault().token;
        }
    }
}