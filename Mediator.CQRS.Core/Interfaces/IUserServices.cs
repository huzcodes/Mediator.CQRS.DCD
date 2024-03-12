using Mediator.CQRS.Shared.Models;

namespace Mediator.CQRS.Core.Interfaces
{
    public interface IUserServices
    {
        public UserModel AddUser(UserModel user);
        public List<UserModel> GetUsers();
        public UserModel GetUserByIndex(int index);
    }
}
