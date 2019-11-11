using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Module1.Models
{
    public class ProductDbContext:DbContext
    {
        public DbSet<Products> Products { get; set; }

        public ProductDbContext(DbContextOptions options):base(options)
        {

        }

    }
}
