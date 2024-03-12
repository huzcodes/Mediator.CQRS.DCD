using Mediator.CQRS.Application.Queries;
using Mediator.CQRS.Core.Interfaces;
using Mediator.CQRS.Shared.Models;
using MediatR;

namespace Mediator.CQRS.Application.Handlers.QueriesHandler
{
    public class ReadUserByIndexQueryHandler : IRequestHandler<ReadUserByIndexQuery, UserModel>
    {
        private readonly IUserServices _userServices;
        public ReadUserByIndexQueryHandler(IUserServices userServices)
        {
            _userServices = userServices;
        }
        public async Task<UserModel> Handle(ReadUserByIndexQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_userServices.GetUserByIndex(request.Index));
        }
    }
}
