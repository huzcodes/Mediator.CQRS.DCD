using Mediator.CQRS.Application.Commands;
using Mediator.CQRS.Core.Interfaces;
using Mediator.CQRS.Shared.Models;
using MediatR;

namespace Mediator.CQRS.Application.Handlers.CommandsHandler
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, UserModel>
    {
        private readonly IUserServices _userServices;
        public AddUserCommandHandler(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public async Task<UserModel> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var oDataModel = new UserModel(request.Id,
                                           request.FirstName,
                                           request.LastName);

            return _userServices.AddUser(oDataModel);
        }
    }
}
