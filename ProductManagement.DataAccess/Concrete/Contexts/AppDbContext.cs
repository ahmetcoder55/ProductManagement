using Microsoft.EntityFrameworkCore;
using ProductManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.DataAccess.Concrete.Contexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<Product> Products { get; set; }


    }
}
