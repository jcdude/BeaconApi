using System;
using System.Collections.Generic;
using System.Text;

namespace BeaconApi.Data.Models
{
    public class User
    {
        public int id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public int containerId { get; set; }

        public string created_on { get; set; }

        public Container container { get; set; }
    }
}
