using Mediator.CQRS.Shared.Models;
using MediatR;

namespace Mediator.CQRS.Application.Queries
{
    public class ReadUserByIndexQuery : IRequest<UserModel>
    {
        public int Index { get; set; }
        public ReadUserByIndexQuery(int index)
        {
            Index = index;
        }
    }
}
