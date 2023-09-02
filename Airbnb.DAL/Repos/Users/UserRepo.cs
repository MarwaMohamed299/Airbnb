using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL.Repos.Users
{
  

    public class UserRepo : GenericRepo<User>, IUserRepo
    {
        private readonly RentContext _rentContext;


        public UserRepo(RentContext rentContext) : base(rentContext)
        {
            _rentContext = rentContext;
        }
        public void Add(User user)
        {
            _rentContext.Set<User>().Add(user);

        }
        public void Update(User user)
        {
        }

        public void Delete(User user)
        {
            _rentContext.Set<User>().Remove(user);
        }

        public IEnumerable<User> GetAll()
        {
            return _rentContext.Set<User>();
        }

        public User? GetUserById(Guid id)
        {
            return _rentContext.Set<User>().Find(id);

        }

      

        public int SaveChanges()
        {
            return _rentContext.SaveChanges();     
        }

       
    }
}
