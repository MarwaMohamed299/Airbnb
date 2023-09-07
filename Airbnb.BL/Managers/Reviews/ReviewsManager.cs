﻿using Airbnb.BL.Dtos.Reviews;
using Airbnb.DAL;
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

       public string Add(ReviewsAddDto reviewsFromRequest)
        {
            UserReviewProperty? reviews = new UserReviewProperty
            {
                Rating = reviewsFromRequest.Rating
            };
            _reviewsRepo.Add(reviews);
            _reviewsRepo.SaveChanges();
            return reviews.UserId;
        }

         public bool Update(ReviewsUpdateDto reviewsFromRequest)
        {
            UserReviewProperty? reviews = _reviewsRepo.GetReviewsByIdForUpdateAndDelete( reviewsFromRequest.PropertyId, reviewsFromRequest.UserId);
            reviews.Rating = reviewsFromRequest.Rating;
            _reviewsRepo.Update(reviews);
            _reviewsRepo.SaveChanges();
            return true;
        }
        public bool Delete(Guid propertyId, Guid userId)
        {
            UserReviewProperty? reviews = _reviewsRepo.GetReviewsByIdForUpdateAndDelete(propertyId, userId);
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
