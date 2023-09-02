using Airbnb.BL.Dtos.Properties;
using Airbnb.BL.Dtos.Users;
using Airbnb.DAL;
using Airbnb.DAL.Repos.Users;


namespace Airbnb.BL.Managers.Users
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepo _userRepo;

        public UserManager(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }


        public IEnumerable<UserReadDto> GetALL()
        {
            IEnumerable<User> UserFromDb = _userRepo.GetAll();
            return UserFromDb.Select(u => new UserReadDto
            {
                Id = u.Id,
                UserRole = u.UserRole,
                FName = u.FName,
                LName = u.LName,
                Email = u.Email,
                Password = u.Password,
                UserName = u.UserName,
                PhoneNumber = u.PhoneNumber,
                Country = u.Country,
                Governorate = u.Governorate,
                City = u.City,
                CreationDate = u.CreationDate


            }); 
        }

        public UserReadDto? GetUserById(Guid id)
        {
            User? userFromDb = _userRepo.GetUserById(id);
            if (userFromDb == null)
            {
                return null;
            }
            return new UserReadDto
            {
                UserRole = userFromDb.UserRole,
                FName = userFromDb.FName,
                LName = userFromDb.LName,
                Email = userFromDb.Email,
                Password = userFromDb.Password,
                UserName = userFromDb.UserName,
                PhoneNumber = userFromDb.PhoneNumber,
                Country = userFromDb.Country,
                Governorate = userFromDb.Governorate,
                City = userFromDb.City,
                CreationDate = userFromDb.CreationDate

            };
        }


        public Guid Add(UserAddDto userFromRequest)
        {
            User user = new User
            {
                UserRole = userFromRequest.UserRole,
                FName = userFromRequest.FName,
                LName = userFromRequest.LName,
                Email = userFromRequest.Email,
                Password = userFromRequest.Password,
                UserName = userFromRequest.UserName,
                PhoneNumber = userFromRequest.PhoneNumber,
                Country = userFromRequest.Country,
                Governorate = userFromRequest.Governorate,
                City = userFromRequest.City,


            };
            _userRepo.Add(user);
            _userRepo.SaveChanges();
            return user.Id;


        }
        public bool Update(UserUpdateDto userFromRequest)
        {
            User? user = _userRepo.GetUserById(userFromRequest.Id);
            if (user == null)
            {
                return false;
            }

            user.UserRole = userFromRequest.UserRole;
            user.FName = userFromRequest.FName;
            user.LName = userFromRequest.LName;
            user.Email = userFromRequest.Email;
            user.Password = userFromRequest.Password;
            user.UserName = userFromRequest.UserName;
            user.PhoneNumber = userFromRequest.PhoneNumber;
            user.Country = userFromRequest.Country;
            user.Governorate = userFromRequest.Governorate;
            user.City = userFromRequest.City;
            user.CreationDate = userFromRequest.CreationDate;

            _userRepo.Update(user);
            _userRepo.SaveChanges();
            return true;

        }
       



        public bool Delete(Guid id)
        {
            User? user = _userRepo.GetUserById(id);
            if (user == null)
            {
                return false;
            }
            _userRepo.Delete(user);

             _userRepo.SaveChanges();
            return true;
        }

    }
}


