using FluentValidation;
using Mediator.CQRS.Application.Commands;

namespace Mediator.CQRS.DCD.Validations
{
    public class AddUserCommandValidator : AbstractValidator<AddUserCommand>
    {
        public AddUserCommandValidator()
        {
            RuleFor(o => o.Id).NotEqual(0);
            RuleFor(o => o.FirstName).NotEmpty();
            RuleFor(o => o.LastName).NotEmpty();
        }
    }
}
