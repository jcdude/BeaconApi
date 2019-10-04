using BeaconApi.Data;
using BeaconApi.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BeaconApi.Core.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;
        public UserService(ApplicationDbContext applicationDbContext)
        {
            _userRepository = new UserRepository(applicationDbContext);
        }

        //Get the token that will be used in each request
        public async Task<string> GetToken(string username, string password)
        {
            return await _userRepository.GetToken(username, password);
        }

        //If the token created or updated date is older then 60 minutes renew token
        public async Task<bool> CheckToken(string token)
        {
            return await _userRepository.CheckToken(token);
        }
    }
}
