using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto.Validation
{
    public class CustomerValidator : AbstractValidator<CustomerDto>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(200).WithMessage("Informe o nome do cliente");
            RuleFor(x => x.Document).NotEmpty().WithMessage("Informe ao menos um documento para o cliente");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Informe o endereço do cliente");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Informe o telefone do cliente");
            RuleFor(x => x.LegalEntity).NotEmpty().WithMessage("Informe o tipo do estacionamento");
        }
    }
}
