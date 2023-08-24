using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class AmenityRepo : GenericRepo<Amenity>, IAmenityRepo
{
    private readonly RentContext _rentContext;
    public AmenityRepo(RentContext rentContext):base(rentContext)
    {
        _rentContext = rentContext;
    }
}
