using CarWorkShop.Application.Mappings;
using CarWorkShop.Application.Services;
using CarWorkShop.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Application.Extensions
{
    public static class ServiceCollectionExcentions
    {
        public static void AddAplication(this IServiceCollection services )
        {
            services.AddScoped<ICarWorkshopService, CarWorkshopService>();

            services.AddAutoMapper(typeof(CarWorkshopMappingProfile));
        }
    }
}
