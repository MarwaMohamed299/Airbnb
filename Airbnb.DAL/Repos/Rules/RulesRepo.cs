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

    public IEnumerable<Rules> GetAllRules()
    {
        return _rentContext.Set<Rules>().ToList();
    }

    public Rules? GetRulesById(Guid Id)
    {
        return _rentContext.Set<Rules>().Find();
    }
    public void Add (Rules rules)
    {
        _rentContext.Set<Rules>().Add(rules);

    }
    public void Update(Rules rules)
    {

    }
    public void Delete(Rules rules)
    {
        _rentContext.Set<Rules>().Remove(rules);

    }
    public int SaveChanges()
    {
        return _rentContext.SaveChanges();
    }
}
