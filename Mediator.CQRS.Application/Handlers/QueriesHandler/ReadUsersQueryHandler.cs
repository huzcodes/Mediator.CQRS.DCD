using Mediator.CQRS.Application.Queries;
using Mediator.CQRS.Core.Interfaces;
using Mediator.CQRS.Shared.Models;
using MediatR;

namespace Mediator.CQRS.Application.Handlers.QueriesHandler
{
    public class ReadUsersQueryHandler : IRequestHandler<ReadUsersQuery, List<UserModel>>
    {
        private readonly IUserServices _userServices;
        public ReadUsersQueryHandler(IUserServices userServices)
        {
            _userServices = userServices;
        }
        public async Task<List<UserModel>> Handle(ReadUsersQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_userServices.GetUsers());
        }
    }
}
