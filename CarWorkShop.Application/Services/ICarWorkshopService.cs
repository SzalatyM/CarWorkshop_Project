﻿using CarWorkShop.Domain.Entities;

namespace CarWorkShop.Application.Services
{
    public interface ICarWorkshopService
    {
        Task Create(Domain.Entities.CarWorkshop carWorkshop);
    }
}