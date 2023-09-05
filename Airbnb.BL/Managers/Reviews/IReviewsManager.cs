using Airbnb.BL.Dtos.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Managers.Reviews
{
    public interface IReviewsManager
    {
        IEnumerable<ReviewsReadDto> GetAllReviews();
        ReviewsReadDto? GetReviewsById(Guid Id);
        string Add(ReviewsAddDto reviews);
        bool Update(ReviewsUpdateDto reviews);
        bool Delete(Guid Id);

    }
}
