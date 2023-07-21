using FluentValidation;
using PrimeiraAPI.Models.InputModel;

namespace PrimeiraAPI.Models.Validator;

public class EmployeesValidatorCreated : AbstractValidator<EmployeesInputModelCreated>
{
    public EmployeesValidatorCreated()
    {
        RuleFor(p => p.UserName)
            .NotEmpty()
            .WithMessage("Campo obrigatório");
    }
}

public class EmployeesValidatorUpdated : AbstractValidator<EmployeesInputModelUpdate>
{
    public EmployeesValidatorUpdated()
    {
        RuleFor(p => p.UserName)
            .NotEmpty()
            .WithMessage("Campo obrigatório");
    }
}
