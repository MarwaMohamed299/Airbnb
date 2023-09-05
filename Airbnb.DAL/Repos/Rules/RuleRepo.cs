using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class RuleRepo:GenericRepo<Rule>, IRuleRepo
{
    private readonly RentContext _rentContext;
    public RuleRepo(RentContext rentContext):base(rentContext)
    {
        _rentContext = rentContext;
    }

    public IEnumerable<Rule> GetAllRules()
    {
        return _rentContext.Set<Rule>().ToList();
    }

    public Rule? GetRulesById(Guid Id)
    {
        return _rentContext.Set<Rule>().Find();
    }
    public void Add (Rule rules)
    {
        _rentContext.Set<Rule>().Add(rules);

    }
    public void Update(Rule rules)
    {

    }
    public void Delete(Rule rules)
    {
        _rentContext.Set<Rule>().Remove(rules);

    }
    public int SaveChanges()
    {
        return _rentContext.SaveChanges();
    }
}
