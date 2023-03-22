using CarWorkShop.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.Controllers
{
    public class CarWorkshopController : Controller
    {
        private readonly ICarWorkshopService _carWorkshopService;

        public CarWorkshopController(ICarWorkshopService carWorkshopService)
        {
            _carWorkshopService = carWorkshopService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CarWorkShop.Domain.Entities.CarWorkshop carWorkshop)
        {
           await _carWorkshopService.Create(carWorkshop);
            return RedirectToAction(nameof(Create));
        }
    
        
    }
}
