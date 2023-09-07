using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public interface IRuleRepo:IGenericRepo<Rule>
{
    IEnumerable<Rule> GetAllRules();
    Rule? GetRulesById(Guid Id);
    void Add(Rule rules);
    void Update(Rule rules);

    void Delete(Rule rules);

    int SaveChanges();
    Rule? GetRulesByIdForUpdateAndDelete(Guid propertyId, Guid userId);
}
