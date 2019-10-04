using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BeaconApi.Data.Repositories
{
    public class UserRepository : Repository
    {
        public UserRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        //Get the token that will be used in each request
        public async Task<string> GetToken(string username,string password)
        {
            var userData = from user in _applicationDbContext.Users
                           where user.username == username && user.password == password
                           select user;
            return userData.FirstOrDefaultAsync().Result.token;
        }

        //If the token created or updated date is older then 60 minutes renew token
        public async Task<bool> CheckToken(string token)
        {
            var userData = from user in _applicationDbContext.Users
                           where user.token == token
                           select user;
            return userData.FirstOrDefaultAsync().Result.token_created_on > (DateTime.Now.AddHours(-1));
        }
    }
}
