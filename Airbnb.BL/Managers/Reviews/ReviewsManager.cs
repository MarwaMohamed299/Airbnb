using Airbnb.BL.Dtos.Reviews;
using Airbnb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Managers.Reviews
{
    public class ReviewsManager :IReviewsManager
    {
        private readonly IReviewRepo _reviewsRepo;

        public ReviewsManager(IReviewRepo reviewsRepo)
        {
            _reviewsRepo = reviewsRepo;
        }
        public IEnumerable<ReviewsReadDto> GetAllReviews()
        {
            IEnumerable<UserReviewProperty> reviewsFromDb = _reviewsRepo.GetAllReviews();
            return reviewsFromDb.Select(r => new ReviewsReadDto
            {
                Rating = r.Rating
            });
        }

        public ReviewsReadDto? GetReviewsById(Guid Id)
        {
            UserReviewProperty? ReviewFromDb = _reviewsRepo.GetReviewsById(Id);
            if (ReviewFromDb == null)
            {
                return null;
            }
            return new ReviewsReadDto
            {
                Rating = ReviewFromDb.Rating
            };
        }

        string IReviewsManager.Add(ReviewsAddDto reviews)
        {
            throw new NotImplementedException();
        }

        bool IReviewsManager.Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

    

        bool IReviewsManager.Update(ReviewsUpdateDto reviews)
        {
            throw new NotImplementedException();
        }
    }
}
