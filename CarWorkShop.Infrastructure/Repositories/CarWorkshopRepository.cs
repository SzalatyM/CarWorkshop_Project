using CarWorkShop.Domain.Entities;
using CarWorkShop.Domain.Interfaces;
using CarWorkShop.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Infrastructure.Repositories
{
    internal class CarWorkshopRepository : ICarWorkshopRepository
    {
        private readonly CarWorkshopDbContext _dbContext;
        public CarWorkshopRepository(CarWorkshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(Domain.Entities.CarWorkshop CarWorkshop)
        {
            _dbContext.Add(CarWorkshop);
            await _dbContext.SaveChangesAsync();
        }
    }
}
