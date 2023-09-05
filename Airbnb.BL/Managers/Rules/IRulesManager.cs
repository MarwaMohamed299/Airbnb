using Airbnb.BL.Dtos.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Managers.Rules
{
    public interface IRulesManager
    {
        IEnumerable<RulesReadDto> GetAllRules();
        RulesReadDto? GetRulesById(Guid Id);
        string Add(RulesReadDto rules);
        bool Update(RulesUpdateDto rules);
        bool Delete(Guid Id);
    }
}
