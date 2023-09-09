using Airbnb.BL.Dtos.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Managers.Reviews
{
    public interface IReviewsManager
    {
        IEnumerable<ReviewsReadDto> GetAllReviews();
        ReviewsReadDto? GetReviewsById(string propertyId, string userId, Guid Id);
        string Add(ReviewsAddDto reviews);
        bool Update(ReviewsUpdateDto reviews);
        bool Delete(string propertyId, string userId , Guid Id);

    }
}
