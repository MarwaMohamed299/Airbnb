using Airbnb.BL.Dtos.GeneralResponse;
using Airbnb.BL.Dtos.Images;
using Airbnb.BL.Dtos.Rules;
using Airbnb.BL.Managers.Images;
using Airbnb.BL.Managers.Rules;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airbnb.APIs.Controllers.Image
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImagesManager _imagesManager;

        public ImagesController(IImagesManager ImagesManager)
        {
            _imagesManager = ImagesManager;
        }

        [HttpGet]
        public ActionResult<List<ImagesReadDto>> GetAll()
        {
            return _imagesManager.GetAllImages().ToList();
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<ImagesReadDto> GetImagesById(Guid id)
        {
            ImagesReadDto? images = _imagesManager.GetImagesById(id);
            if (images is null)
            {
                return NotFound();
            }
            return images;
        }
        [HttpPost]
        public ActionResult Add(ImagesAddDto imagesDto)
        {
            var newId = _imagesManager.Add(imagesDto);
            return CreatedAtAction(nameof(GetImagesById),
                new { id = newId },
                new GeneralResponse("Image Has Been Added Successfully!"));

        }

        [HttpPut]
        public ActionResult Update(ImagesUpdateDto imagesDto)

        {
            var isFound = _imagesManager.Update(imagesDto);
            if (!isFound)
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(Guid Id)
        {
            var isFound = _imagesManager.Delete(Id);
            if (!isFound)
            {
                return NotFound();

            }
            return NoContent();
        }

    }
}
