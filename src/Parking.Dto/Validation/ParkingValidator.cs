using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto.Validation
{
    public class ParkingValidator : AbstractValidator<ParkingDto>
    {
        public ParkingValidator()
        {
            RuleFor(x => x.Description).NotEmpty().MaximumLength(200).WithMessage("Informe um nome ou verifique o tamanho máximo do campo Descrição");
            RuleFor(x => x.Document).NotEmpty().WithMessage("Informe ao menos um documento para o estacionamento");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Informe o endereço do estacionamento");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Informe o telefone do estacionamento");
        }
    }
}
