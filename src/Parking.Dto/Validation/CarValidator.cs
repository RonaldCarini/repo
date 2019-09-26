using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto.Validation
{
    public class CarValidator : AbstractValidator<CarDto>
    {
        public CarValidator()
        {
            RuleFor(x => x.Model).NotEmpty().MaximumLength(200).WithMessage("Informe o modelo do carro");
            RuleFor(x => x.Color).NotEmpty().WithMessage("Informe a cor do carro");
            RuleFor(x => x.Year).NotEmpty().WithMessage("Informe o ano do carro");
            RuleFor(x => x.LicensePlate).NotEmpty().WithMessage("Informe a placa do carro");
        }
    }
}
