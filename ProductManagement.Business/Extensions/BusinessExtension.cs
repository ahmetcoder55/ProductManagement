using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ProductManagement.Business.Mapping;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProductManagement.Business.Extensions
{
    public static class BusinessExtension
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

            services.AddAutoMapper(cfg => cfg.AddMaps(typeof(GeneralMapping)));

            services.AddValidatorsFromAssembly(assembly);


        }
    }
}
