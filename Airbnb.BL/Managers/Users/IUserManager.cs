using Airbnb.BL.Dtos.Users;


namespace Airbnb.BL.Managers.Users
{
    public interface IUserManager
    {
        IEnumerable<UserReadDto> GetALL();
        UserReadDto? GetUserById(Guid id);

        System.Guid Add(UserAddDto user);
        bool Update(UserUpdateDto user);
        bool Delete(Guid id);

    }
}
