using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto.Validation
{
    public class AgreementValidator : AbstractValidator<AgreementDto>
    {
        public AgreementValidator()
        {
            RuleFor(x => x.Description).NotEmpty().MaximumLength(200).WithMessage("Informe a descrição do convênio");
            RuleFor(x => x.DiscountAmount).NotEmpty().WithMessage("Informe o valor de desconto de convênio");
            RuleFor(x => x.DiscountPercentage).NotEmpty().WithMessage("Informe o percentual de desconto do convênio");            
        }
    }
}
