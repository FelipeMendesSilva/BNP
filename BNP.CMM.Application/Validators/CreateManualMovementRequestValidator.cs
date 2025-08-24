using BNP.CMM.Application.Requests;
using FluentValidation;

namespace BNP.CMM.Application.Validators
{
    public class CreateManualMovementRequestValidator : AbstractValidator<CreateManualMovementRequest>
    {
        public CreateManualMovementRequestValidator()
        {
            RuleFor(x => x.Month)
                .InclusiveBetween(1, 12).WithMessage("O mês deve ser entre 1 e 12.");

            RuleFor(x => x.Year)
                .InclusiveBetween(1900, 2200).WithMessage("O ano deve ser entre 1900 e 2200.");

            RuleFor(x => x.ProductId)
                .NotEmpty().WithMessage("O produto é obrigatório.")
                .NotNull().WithMessage("O produto é obrigatório.");

            RuleFor(x => x.CosifId)
                .NotEmpty().WithMessage("O Cosif é obrigatório.")
                .NotNull().WithMessage("O Cosif é obrigatório.");

            RuleFor(x => x.Amount)
                .InclusiveBetween(0.01M, 999999.99M).WithMessage("O valor deve ser maior que 0,01 e inferior a 1.000.000.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("A descrição é obrigatória.")
                .NotNull().WithMessage("A descrição é obrigatória.")
                .MaximumLength(50).WithMessage("A descrição deve conter no máximo 50 caracteres.");


        }
    }
}
