using BeaconApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeaconApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Beacon> Beacons { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserBeacon> UserBeacons { get; set; }

        public DbSet<Container> Containers { get; set; }
    }
}
