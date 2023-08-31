using Airbnb.BL.Dtos.GeneralResponse;
using Airbnb.BL.Dtos.Properties;
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
          return _propertyManager.GetAll().ToList();
          
        }


        [HttpGet]
        [Route("{id}")]
        public ActionResult<PropertyReadDto> GetById(int id)
        {
              PropertyReadDto? property = _propertyManager.GetById(id);
            if (property is null)
            {
                return NotFound();
            }
            return property;
        }

        [HttpPost]
        public ActionResult Add (PropertyAddDto propertyDto)
        {
            var newId =_propertyManager.Add(propertyDto);
            return CreatedAtAction(nameof(GetById),
                new { id = newId },
                new GeneralResponse("Property Has Been Added Successfully!"));

        }

        [HttpPut]
        public ActionResult Update (PropertyUpdateDto propertyDto)

        {
            var isFound = _propertyManager.Update(propertyDto);
            if (!isFound)
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete (int id)
        {
            var isFound = _propertyManager.Delete(id);
            if(!isFound)
            {
                return NotFound();

            }
            return NoContent();
        }
        
    }

}
