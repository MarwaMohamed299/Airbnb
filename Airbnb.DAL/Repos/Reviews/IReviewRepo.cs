using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public interface IReviewRepo:IGenericRepo<UserReviewProperty>
{
    IEnumerable<UserReviewProperty> GetAllReviews();
    UserReviewProperty? GetReviewsById(Guid Id);
    void Add(UserReviewProperty userReviewProperty);
    void Update(UserReviewProperty userReviewProperty);
    void Delete(UserReviewProperty userReviewProperty);
    int SaveChanges();
    UserReviewProperty? GetReviewsByIdForUpdateAndDelete(Guid PropertyId, Guid UserId);
}
