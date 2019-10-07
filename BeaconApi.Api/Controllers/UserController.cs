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
        public async Task<ActionResult<string>> GetToken(string username, string password)
        {
            return await _userService.GetToken(username, password);
        }

        [HttpGet("{token}")]
        public async Task<ActionResult<bool>> CheckToken(string token)
        {
            return await _userService.CheckToken(token);
        }
    }
}