using CadFuncionario.Domain.Entities;
using FluentValidation;

namespace CadFuncionario.Validations
{
    public class ProfissaoValidation : AbstractValidator<Profissao>
    {
        public ProfissaoValidation()
        {
            RuleFor(p => p.Descricao)
                .NotEmpty().WithMessage("Informe a descrição")
                .MaximumLength(80).WithMessage("A descrição deve conter no máximo 80 caracteres");

            RuleFor(p => p.SalarioBase)
                .NotEmpty().WithMessage("Informe o salário base");
        }
    }
}