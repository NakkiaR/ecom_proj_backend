using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<>
    }
}
