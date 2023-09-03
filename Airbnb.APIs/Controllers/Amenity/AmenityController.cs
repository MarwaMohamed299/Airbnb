using Airbnb.BL.Dtos.Amenities;
using Airbnb.BL.Dtos.GeneralResponse;
using Airbnb.BL.Dtos.Properties;
using Airbnb.BL.Managers.Amenities;
using Airbnb.BL.Managers.properties;
using Microsoft.AspNetCore.Mvc;

namespace Airbnb.APIs.Controllers.Amenity
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmenityController : ControllerBase
    {
        [Route("api/[controller]")]
        [ApiController]
        public class PropertyController : ControllerBase
        {
            private readonly IAmenityManager _amenityManager;

            public PropertyController(IAmenityManager amenityManager)
            {
                amenityManager = _amenityManager;

            }
            [HttpGet]
            public ActionResult <List<AmenityReadDto>> GetAll()
            {
            return _amenityManager.GetAll().ToList();
            }


            [HttpGet]
            [Route("{id}")]
            public ActionResult<AmenityReadDto> GetAmenityById(Guid id)
            {
                AmenityReadDto? Amenity = _amenityManager.GetAmenityById(id);
                if (Amenity is null)
                {
                    return NotFound();
                }
                return Amenity;
            }

            [HttpPost]
            public ActionResult Add(AmenityAddDto amenityDto)
            {
                var newId = _amenityManager.Add(amenityDto);
                return CreatedAtAction(nameof(GetAmenityById),
                    new { id = newId },
                    new GeneralResponse("Amenity Has Been Added Successfully!"));

            }

            [HttpPut]
            public ActionResult Update(AmenityUpdateDto amenityDto)

            {
                var isFound = _amenityManager.Update(amenityDto);
                if (!isFound)
                {
                    return NotFound();
                }
                return NoContent();
            }
            [HttpDelete]
            [Route("{id}")]
            public ActionResult Delete(Guid id)
            {
                var isFound = _amenityManager.Delete(id);
                if (!isFound)
                {
                    return NotFound();

                }
                return NoContent();
            }

        }

    }

}

