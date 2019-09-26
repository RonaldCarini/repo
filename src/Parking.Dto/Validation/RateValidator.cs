using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto.Validation
{
    public class RateValidator : AbstractValidator<RateDto>
    {
        public RateValidator()
        {
            RuleFor(x => x.Description).NotEmpty().MaximumLength(200).WithMessage("Informe a descrição da tarifa");
            RuleFor(x => x.DailyAmount).NotEmpty().WithMessage("Informe o valor da diária da tarifa");
            RuleFor(x => x.PeriodAmount).NotEmpty().WithMessage("Informe o valor da tarifa por período");
            RuleFor(x => x.OvernightAmount).NotEmpty().WithMessage("Informe o valor da tarifa por pernoite");
        }
    }
}
