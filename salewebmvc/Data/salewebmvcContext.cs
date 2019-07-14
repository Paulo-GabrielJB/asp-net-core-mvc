using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace salewebmvc.Models
{
    public class salewebmvcContext : DbContext
    {
        public salewebmvcContext (DbContextOptions<salewebmvcContext> options)
            : base(options)
        {
        }

        public DbSet<salewebmvc.Models.Department> Department { get; set; }
    }
}
