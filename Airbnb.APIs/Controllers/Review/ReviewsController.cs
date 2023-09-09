using Airbnb.BL.Dtos.GeneralResponse;
using Airbnb.BL.Dtos.Reviews;
using Airbnb.BL.Dtos.Rules;
using Airbnb.BL.Managers.Reviews;
using Airbnb.BL.Managers.Rules;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airbnb.APIs.Controllers.Review
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewsManager _reviewsManager;

        public ReviewsController(IReviewsManager reviewsManager)
        {
            _reviewsManager = reviewsManager;
        }
        [HttpGet]
        public ActionResult<List<ReviewsReadDto>> GetAllReviews()
        {
            return _reviewsManager.GetAllReviews().ToList();
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<ReviewsReadDto> GetReviewsById(string propertyId, string userId, Guid Id)
        {
            ReviewsReadDto? reviews = _reviewsManager.GetReviewsById( propertyId,  userId,Id);
            if (reviews is null)
            {
                return NotFound();
            }
            return reviews;
        }
        [HttpPost]
        public ActionResult Add(ReviewsAddDto reviewsDto)
        {
            var newId = _reviewsManager.Add(reviewsDto);
            return CreatedAtAction(nameof(GetReviewsById),
                new { id = newId },
                new GeneralResponse("Review Has Been Added Successfully!"));

        }

        [HttpPut]
        public ActionResult Update(ReviewsUpdateDto reviewsDto)

        {
            var isFound = _reviewsManager.Update(reviewsDto);
            if (!isFound)
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(string UserId, string PropertyId,Guid Id)
        {
            var isFound = _reviewsManager.Delete(UserId, PropertyId, Id);
            if (!isFound)
            {
                return NotFound();

            }
            return NoContent();
        }


    }
}
