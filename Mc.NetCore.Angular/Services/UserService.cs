namespace Mc.NetCore.Angular.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Mc.NetCore.Angular.Model;

    public class UserService : IUserService
    {
        private readonly IList<User> _users;

        public UserService()
        {
            _users = new List<User>();
        }

        public IList<User> Get()
        {
            return _users;
        }

        public User Get(int id)
        {
            return _users.Where(user => user.Id == id).FirstOrDefault();
        }

        public void Save(User user)
        {
            _users.Add(user);
        }

        public void Update(User user)
        {
            _users.Where(userDb => user.Id == userDb.Id).ForEach(userDb =>
            {
                userDb.Email = user.Email;
                userDb.Name = user.Name;
            });
        }
    }
}
