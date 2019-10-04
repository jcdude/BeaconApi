using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeaconApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeaconApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeaconController : BaseController
    {
        public BeaconController(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }


    }
}