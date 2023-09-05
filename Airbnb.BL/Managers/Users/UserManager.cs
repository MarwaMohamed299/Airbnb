using Airbnb.BL.Dtos.Properties;
using Airbnb.BL.Dtos.Users;
using Airbnb.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Airbnb.BL.Managers.Users
{
    public class UserManager:IUserManager
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _config;

        public UserManager(UserManager<User> userManager, IConfiguration config)
        {
            _userManager = userManager;
            _config = config;
        }



        public async Task<IEnumerable<IdentityError>?> Add(RegisterDto userFromRequest)
        {
            User user = new User
            {
                Id = Guid.NewGuid().ToString(),
                FName = userFromRequest.FName,
                LName = userFromRequest.LName,
                Email = userFromRequest.Email,
                UserName = userFromRequest.UserName,
                PhoneNumber = userFromRequest.PhoneNumber,
                Country = userFromRequest.Country,
                Governorate = userFromRequest.Governorate,
                City = userFromRequest.City,
            };
            var RegisterResult = await _userManager.CreateAsync(user, userFromRequest.Password);
            if (!RegisterResult.Succeeded)
            {
                return RegisterResult.Errors;
            }
            else
            {
                var userClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, userFromRequest.UserName),
                    new Claim(ClaimTypes.Email, userFromRequest.Email),
                    new Claim("Nationality", "Egyptian"),
                };
                await _userManager.AddClaimsAsync(user, userClaims);
                return null;
            }
        }

        public async Task<LoginResultDto> Login(LoginDto credentials)
        {
            LoginResultDto resultDto = new LoginResultDto();
            var user = await _userManager.FindByNameAsync(credentials.UserName);
            if (user is null)
            {
                resultDto.Success = false;
                resultDto.Message = "User Name Or Password Isn't Correct";
                return resultDto;
            }
            if(await _userManager.IsLockedOutAsync(user))
            {
                resultDto.Success = false;
                resultDto.Message = "User Is Locked, Try again after 2 minutes";
                return resultDto;
            }
            if(!(await _userManager.CheckPasswordAsync(user, credentials.Password)))
            {
                await _userManager.AccessFailedAsync(user);
                resultDto.Success = false;
                resultDto.Message = "User Name Or Password Isn't Correct";
                return resultDto;
            }
            var secretKey = _config.GetValue<string>("SecretKey");
            var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKey);
            var key = new SymmetricSecurityKey(secretKeyInBytes);
            var generatingToken = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
            var userClaims = await _userManager.GetClaimsAsync(user);
            var jwt = new JwtSecurityToken
                (
                    claims:userClaims, 
                    notBefore:DateTime.Now,
                    issuer:"BackendTeam",
                    audience:"users",
                    expires:DateTime.Now.AddMinutes(15),
                    signingCredentials:generatingToken
                );
            var tokenHandler = new JwtSecurityTokenHandler();
            string tokenString = tokenHandler.WriteToken(jwt);
            resultDto.Success = true;
            resultDto.Message = "Login Successfully";
            resultDto.Token = tokenString;
            resultDto.ExpiryDate = jwt.ValidTo;
            return resultDto;
        }
    }
}


