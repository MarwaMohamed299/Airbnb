using Airbnb.BL.Dtos.Reviews;
using Airbnb.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
                Rating = r.Rating,
                Id=r.Id,
                UserId=r.UserId,
                PropertyId=r.PropertyId
            });
        }

        public ReviewsReadDto? GetReviewsById(string PropertyId,string UserId,Guid Id)
        {
            UserReviewProperty? ReviewFromDb = _reviewsRepo.GetReviewsById( PropertyId,UserId, Id);
            if (ReviewFromDb == null)
            {
                return null;
            }
            return new ReviewsReadDto
            {
                Rating = ReviewFromDb.Rating
            };
        }




        public string Add(ReviewsAddDto reviewsFromRequest)
        {
            UserReviewProperty? reviews = new UserReviewProperty
            {
                UserId = reviewsFromRequest.UserId,
                PropertyId = reviewsFromRequest.PropertyId,
                Rating = reviewsFromRequest.Rating
            };
            _reviewsRepo.Add(reviews);
            _reviewsRepo.SaveChanges();
            return reviews.UserId;
        }

        public bool Update(ReviewsUpdateDto reviewsFromRequest)
        {
            UserReviewProperty? reviews = _reviewsRepo.GetReviewsByIdForUpdateAndDelete(reviewsFromRequest.PropertyId, reviewsFromRequest.UserId,reviewsFromRequest.Id);
            if (reviews == null)
            {
                return false;
            }
            reviews.Rating = reviewsFromRequest.Rating;
            _reviewsRepo.Update(reviews);
            _reviewsRepo.SaveChanges();
            return true;
        }

        public bool Delete(string propertyId, string userId,Guid  Id)
        {
            UserReviewProperty? reviews = _reviewsRepo.GetReviewsByIdForUpdateAndDelete( propertyId, userId,Id);
            if (reviews == null)
            {
                return false;
            }
            _reviewsRepo.Delete(reviews);
            _reviewsRepo.SaveChanges();
            return true;
        }

    }
}
