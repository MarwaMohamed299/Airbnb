using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public interface IRulesRepo:IGenericRepo<Rules>
{
    IEnumerable<Rules> GetAllRules();
    Rules? GetRulesById(Guid Id);
    void Add(Rules rules);
    void Update(Rules rules);

    void Delete(Rules rules);

    int SaveChanges();

}
