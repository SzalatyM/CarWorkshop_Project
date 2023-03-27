using CarWorkShop.Application.Services;
using CarWorkShop.Domain.Interfaces;
using CarWorkShop.Infrastructure.Persistence;
using CarWorkShop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CarWorkShop.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CarWorkshopDbContext>(options => options.UseSqlServer(
            configuration.GetConnectionString("CarWorkshop")));
            services.AddScoped<ICarWorkshopRepository, CarWorkshopRepository>();
        }
    }
}
