using BeaconApi.Data.DTOs.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BeaconApi.Core.Services
{
    public interface IUserService
    {
        Task<string> GetToken(string username, string password);
        Task<bool> CheckToken(string token);
        Task<List<ContainerDTO>> GetContainers()
    }
}
