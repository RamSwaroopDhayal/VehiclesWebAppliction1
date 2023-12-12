using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace VehiclesWebAppliction.Models
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<VehiclesModel> vehiclesModels { get; set; }
    }
}
