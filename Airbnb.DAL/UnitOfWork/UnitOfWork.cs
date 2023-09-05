using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class UnitOfWork : IUnitOfWork
{
    public IPropertyRepo PropRepo { get; }
    public IAmenityRepo AmenityRepo { get; }
    public IImageRepo ImageRepo { get; }
    public IReservationRepo ReservationRepo { get; }
    public IReviewRepo ReviewRepo { get; }
    public IRuleRepo RulesRepo { get; }
    private readonly RentContext _rentContext;

    public UnitOfWork
        (
            RentContext rentContext,
            IPropertyRepo propertyRepo,
            IAmenityRepo amenityRepo,
            IImageRepo imageRepo,
            IReservationRepo reservationRepo,
            IReviewRepo reviewRepo,
            IRuleRepo rulesRepo
        )
            {
                _rentContext = rentContext;
                PropRepo = propertyRepo;
                AmenityRepo = amenityRepo;
                ImageRepo = imageRepo;
                ReservationRepo = reservationRepo;
                ReviewRepo = reviewRepo;
                RulesRepo = rulesRepo;
            }
    public async Task<int> save()=>await _rentContext.SaveChangesAsync();
    
}
