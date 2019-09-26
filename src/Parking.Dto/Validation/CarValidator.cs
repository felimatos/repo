using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Dto.Validation
{
    public class CarValidator: AbstractValidator<CarDto>
    {
        public CarValidator()
        {
            RuleFor(x => x.CarPlate).NotEmpty().MaximumLength(200).WithMessage("Informe a placa");
            RuleFor(x => x.Color).NotEmpty().WithMessage("Informe a cor");
            RuleFor(x => x.YearModel).NotEmpty().WithMessage("Informe o ano/modelo");
        }
    }
}
