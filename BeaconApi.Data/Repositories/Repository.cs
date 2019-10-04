using System;
using System.Collections.Generic;
using System.Text;

namespace BeaconApi.Data.Repositories
{
    public abstract class Repository
    {
        public ApplicationDbContext _applicationDbContext;
        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
    }
}
