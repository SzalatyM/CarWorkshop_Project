﻿using AutoMapper;
using CarWorkShop.Application.CarWorkshop;
using CarWorkShop.Domain.Interfaces;

namespace CarWorkShop.Application.Services
{
    public class CarWorkshopService : ICarWorkshopService
    {
        private readonly ICarWorkshopRepository _carWorkshopRepository;
        private readonly IMapper _mapper;

        public CarWorkshopService(ICarWorkshopRepository carWorkshopRepository, IMapper mapper)
        {
            _carWorkshopRepository = carWorkshopRepository;
            _mapper = mapper;
        }

        public async Task Create(CarWorkshopDto carWorkshopDto)
        {

            var carWorkshop = _mapper.Map<Domain.Entities.CarWorkshop>(carWorkshopDto);


            carWorkshop.EncodeName();
            await _carWorkshopRepository.Create(carWorkshop);
        }


    }
}
