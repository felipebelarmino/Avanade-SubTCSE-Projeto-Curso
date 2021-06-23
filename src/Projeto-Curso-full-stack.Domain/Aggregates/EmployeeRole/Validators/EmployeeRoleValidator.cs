using FluentValidation;

namespace Projeto_Curso_full_stack.Domain.Aggregates.EmployeeRole.Validators
{
    public class EmployeeRoleValidator : AbstractValidator<Entities.EmployeeRole>
    {
        public EmployeeRoleValidator()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.RoleName)
                    .NotEmpty()
                    .WithMessage("{PropertyName} can not be empty.");
            });
        }
    }
}
