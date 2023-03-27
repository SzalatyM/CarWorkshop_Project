using AutoMapper;
using CarWorkShop.Application.CarWorkshop;
using CarWorkShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Application.Mappings
{
    public class CarWorkshopMappingProfile : Profile   // DTO Connecting PROPERTIES!! :)
    {
        public CarWorkshopMappingProfile()
        {
            CreateMap<CarWorkshopDto, Domain.Entities.CarWorkshop>()
                .ForMember(e => e.ContactDetails, opt => opt.MapFrom(src => new CarWorkShopContactDetails()
                {
                    City = src.City,
                    PhoneNumber = src.PhoneNumber,
                    PostalCode  = src.PostalCode,
                    Street = src.Street,
                }));
        }
    }
}
