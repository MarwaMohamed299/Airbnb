using Airbnb.BL.Dtos.GeneralResponse;
using Airbnb.BL.Dtos.Properties;
using Airbnb.BL.Dtos.Users;
using Airbnb.BL.Managers.Users;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

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


        [HttpGet]
        public ActionResult<List<UserReadDto>> GetAll()
        {
            return _userManager.GetALL().ToList();
        }

        [HttpGet]
        [Route("{id}")]

        public ActionResult<UserReadDto> GetUserById(Guid id)
        {
            UserReadDto? user = _userManager.GetUserById(id);
            if (user is null)
            {
                return NotFound();
            }
            return user;
        }

        [HttpPost]
        public ActionResult Add(UserAddDto userDto)
        {
            var newId = _userManager.Add(userDto);
            return CreatedAtAction(nameof(GetUserById),
                new { id = newId },
                new GeneralResponse("User Has Been Added Successfully!"));
        }

        [HttpPut]
        public ActionResult Update(UserUpdateDto userDto)
        {
            var isFound = _userManager.Update(userDto);
                if (!isFound) 
            {
                return NotFound();
            }
            return NoContent();


        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(Guid id)
        { var isFound = _userManager.Delete(id);
            if (!isFound)
            {
                return NotFound();
            }
            return NoContent();



        }
    }
}
