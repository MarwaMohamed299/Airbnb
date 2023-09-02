using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL.Repos.Users
{
    public interface IUserRepo : IGenericRepo<User>
    {
        IEnumerable<User> GetAll();
        User? GetUserById(Guid id);
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        int SaveChanges();
    }
}
