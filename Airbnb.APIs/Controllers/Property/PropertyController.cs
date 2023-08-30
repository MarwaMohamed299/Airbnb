using Airbnb.APIs.Dtos.Properties;
using Airbnb.BL.Managers.properties;
using Microsoft.AspNetCore.Mvc;



namespace Airbnb.APIs.Controllers.Property
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private IPropertyManager _propertyManager;

        public PropertyController(IPropertyManager propertyManager)
        {
            _propertyManager = propertyManager;
        }
        [HttpGet]
        public ActionResult<List<PropertyReadDto>> GetAll()
        {
             var properties =_propertyManager.GetAll().ToList();
            return Ok();
        }


        //[HttpGet]
        //[Route("{id}")]
        //public ActionResult<PropertyReadDto> GetById(int id)
        //{
        //  //  PropertyReadDto? property = _propertyManager.GetById(id);
        //    if (property is null)
        //    {
        //        return NotFound();
        //    }
        //    return property;
        //}
    }

}
