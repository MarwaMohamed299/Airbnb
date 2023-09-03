using Airbnb.BL;
using Airbnb.BL.Dtos.GeneralResponse;
using Airbnb.BL.Dtos.Properties;
using Airbnb.BL.Dtos.Users;
using Airbnb.BL.Managers.Users;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Airbnb.APIs.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register(RegisterDto userDto)
        {
            var result = await _userManager.Add(userDto);
            if (result is null)
            {
                return Ok("User Created Successfully");
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<LoginResultDto>> Login(LoginDto credentials)
        {
            var result = await _userManager.Login(credentials);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return result;
        }
    }
}
