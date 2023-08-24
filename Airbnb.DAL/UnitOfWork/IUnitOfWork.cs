using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public interface IUnitOfWork
{
    public IPropertyRepo PropRepo { get; }
    public IAmenityRepo AmenityRepo { get; }
    public IImageRepo ImageRepo { get; }
    public IReservationRepo ReservationRepo { get; }
    public IReviewRepo ReviewRepo { get; }
    public IRulesRepo RulesRepo { get; }
    Task<int> save();
}
