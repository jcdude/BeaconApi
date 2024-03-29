﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BeaconApi.Data.Models;
using BeaconApi.Data.DTOs.User;

namespace BeaconApi.Data.Repositories
{
    public class UserRepository : Repository
    {
        public UserRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public async Task<List<ContainerDTO>> GetContainers()
        {
            var userData = from container in _applicationDbContext.Containers                           
                           select new ContainerDTO {id = container.id,containerName = container.containerName };
            return await userData.ToListAsync();
        }

        //Get the token that will be used in each request
        public async Task<string> GetToken(string username,string password)
        {
            var userData = from user in _applicationDbContext.Users
                           where user.username == username && user.password == password
                           select user.token;
            return await userData.FirstOrDefaultAsync();
        }

        //If the token created or updated date is older then 60 minutes renew token
        public async Task<bool> CheckToken(string token)
        {
            return await Task.Run(() => CheckTokenExpired(token));
        }



        private bool CheckTokenExpired(string token)
        {
            var userData = from user in _applicationDbContext.Users
                           where user.token == token
                           select user.token_created_on;
            return userData.FirstOrDefault() > (DateTime.Now.AddHours(-1));
        }
    }
}
