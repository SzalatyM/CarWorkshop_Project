using CarWorkShop.Application.CarWorkshop;
using CarWorkShop.Domain.Entities;

namespace CarWorkShop.Application.Services
{
    public interface ICarWorkshopService
    {
        Task Create(CarWorkshopDto carWorkshop);
    }
}