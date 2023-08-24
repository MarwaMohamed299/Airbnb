using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class ReservationRepo : GenericRepo<UserReserveProperty>, IReservationRepo
{
    private readonly RentContext _rentContext;

    public ReservationRepo(RentContext rentContext):base(rentContext)
    {
        _rentContext = rentContext;
    }
}
