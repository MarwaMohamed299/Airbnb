﻿using Airbnb.APIs.Filters;
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
          return _propertyManager.GetAllProperties().ToList();
          
        }


        [HttpGet]
        [Route("{id}")]
        public ActionResult<PropertyReadDto> GetPropertyById(string id)
        {
              PropertyReadDto? property = _propertyManager.GetPropertyById(id);
            if (property is null)
            {
                return NotFound();
            }
            return property;
        }

        [HttpPost]
        [ValidateCountry]
        public ActionResult Add (ResevationAddDto propertyDto)
        {
            var newId =_propertyManager.Add(propertyDto);
            return CreatedAtAction(nameof(GetPropertyById),
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
        public ActionResult Delete (string id)
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
