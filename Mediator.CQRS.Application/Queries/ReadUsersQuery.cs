using Mediator.CQRS.Shared.Models;
using MediatR;

namespace Mediator.CQRS.Application.Queries
{
    public class ReadUsersQuery : IRequest<List<UserModel>>
    {
    }
}
