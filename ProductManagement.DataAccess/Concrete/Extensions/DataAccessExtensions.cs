using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductManagement.DataAccess.Abstract;
using ProductManagement.DataAccess.Concrete.Contexts;
using ProductManagement.DataAccess.Concrete.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.DataAccess.Concrete.Extensions
{
    public static class DataAccessExtensions
    {
        public static void ConfigureDatabase(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
        public static void ConfigureDataAccess(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
    }
}
