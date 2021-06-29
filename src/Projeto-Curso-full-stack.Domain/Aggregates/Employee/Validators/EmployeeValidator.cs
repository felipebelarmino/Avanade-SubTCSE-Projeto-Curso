using FluentValidation;
using Projeto_Curso_full_stack.Domain.Aggregates.EmployeeRole.Validators;

namespace Projeto_Curso_full_stack.Domain.Aggregates.Employee.Validators
{
    public class EmployeeValidator : AbstractValidator<Entities.Employee>
    {
        public EmployeeValidator()
        {
            RuleSet("new", () => 
            {
                RuleFor(e => e.FirstName)
                .NotEmpty()
                .WithMessage("{PropertyName} não pode estar vazio.");

                RuleFor(e => e.SurName)
                .NotEmpty()
                .WithMessage("{PropertyName} não pode estar vazio.");

                RuleFor(e => e.EmployeeRole)
                .SetValidator(new EmployeeRoleValidator());
            });
        }
    }
}
