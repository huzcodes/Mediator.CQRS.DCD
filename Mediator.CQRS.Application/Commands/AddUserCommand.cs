
using Mediator.CQRS.Shared.Models;
using MediatR;

namespace Mediator.CQRS.Application.Commands
{
    public class AddUserCommand : IRequest<UserModel>
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public AddUserCommand(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
