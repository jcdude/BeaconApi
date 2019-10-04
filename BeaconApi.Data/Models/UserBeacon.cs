using System;
using System.Collections.Generic;
using System.Text;

namespace BeaconApi.Data.Models
{
    public class UserBeacon
    {
        public int id { get; set; }

        public int beaconId { get; set; }

        public int userId { get; set; }

        public Beacon beacon { get; set; }

        public User user { get; set; }
    }
}
