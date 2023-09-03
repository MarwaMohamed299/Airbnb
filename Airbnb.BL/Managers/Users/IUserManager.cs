using Airbnb.BL.Dtos.Users;
using Microsoft.AspNetCore.Identity;

namespace Airbnb.BL.Managers.Users
{
    public interface IUserManager
    {
        public Task<IEnumerable<IdentityError>> Add(RegisterDto userFromRequest);
        public Task<LoginResultDto> Login(LoginDto credentials);
    }
}
