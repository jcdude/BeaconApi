using BeaconApi.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeaconApi.Data.DTOs.User
{
    public class UserDTO
    {
        public string username { get; set; }

        public string password { get; set; }

        public int containerId { get; set; }

        public string token { get; set; }

        public int roleId { get; set; }

        public Container container { get; set; }

        public Role role { get; set; }
    }
}
