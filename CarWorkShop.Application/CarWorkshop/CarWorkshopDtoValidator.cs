﻿using CarWorkShop.Domain.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Application.CarWorkshop
{
    public class CarWorkshopDtoValidator : AbstractValidator<CarWorkshopDto>
    {
        public CarWorkshopDtoValidator(ICarWorkshopRepository repository)
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .MinimumLength(2).WithMessage("Name Should have at least 2 characters")
                .MaximumLength(20).WithMessage("Name should have maximum of 20 characters")
                 .Custom((value, context) => 
                 {
                     var existingCarWorkshop = repository.GetByName(value);
                     if(existingCarWorkshop != null)
                     {
                         context.AddFailure($"{value} is not unique name for car workshop");
                     }
                 });

            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("Please enter description");

            RuleFor(c => c.PhoneNumber)
                .NotEmpty().WithMessage("Please enter number")
            .MinimumLength(8)
            .MaximumLength(12);
        }
    }
}
