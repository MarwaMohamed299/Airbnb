using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

internal class ReviewRepo:GenericRepo<UserReviewProperty>,IReviewRepo
{
    private readonly RentContext _rentContext;

    public ReviewRepo(RentContext rentContext):base(rentContext)
    {
        _rentContext = rentContext;
    }
}
