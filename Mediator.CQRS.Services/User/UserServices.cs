using Mediator.CQRS.Core.Interfaces;
using Mediator.CQRS.Shared.Models;

namespace Mediator.CQRS.Services.User
{
    public class UserServices : IUserServices
    {
        private static List<UserModel> _users = new List<UserModel>() 
        {
            new UserModel()
            {
                Id = 1,
                FirstName = "Ahmed",
                LastName = "Hussain"
            },
            new UserModel()
            {
                Id = 2,
                FirstName = "John",
                LastName = "Next"
            },
            new UserModel()
            {
                Id = 3,
                FirstName = "Maia",
                LastName = "Radwan"
            },
        };
        public UserModel AddUser(UserModel user)
        {
            _users.Add(user);
            return user;
        }

        public UserModel GetUserByIndex(int index)
        {
            return _users[index];
        }

        public List<UserModel> GetUsers()
        {
            return _users;
        }
    }
}
