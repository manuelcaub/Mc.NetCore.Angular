namespace Mc.NetCore.Angular.Services
{
    using System.Collections.Generic;
    using Mc.NetCore.Angular.Model;

    public interface IUserService
    {
        IList<User> Get();

        User Get(int id);

        void Save(User user);

        void Update(User user);
    }
}