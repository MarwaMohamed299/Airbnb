using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class RulesRepo:GenericRepo<Rules>, IRulesRepo
{
    private readonly RentContext _rentContext;
    public RulesRepo(RentContext rentContext):base(rentContext)
    {
        _rentContext = rentContext;
    }
}
