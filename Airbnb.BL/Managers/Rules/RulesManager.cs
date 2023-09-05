using Airbnb.BL.Dtos.Rules;
using Airbnb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Managers.Rules
{
    public class RulesManager : IRulesManager
    {
        private readonly IRuleRepo _ruleRepo;

        public RulesManager(IRuleRepo ruleRepo)
        {
            _ruleRepo = ruleRepo;
        }

       public IEnumerable<RulesReadDto> GetAllRules()
        {
            IEnumerable<Rule> rulesFromDb = _ruleRepo.GetAllRules();
            return rulesFromDb.Select(r => new RulesReadDto
            {
                Id = r.Id,
                Name = r.Name,
                Picture = r.Picture
            });
        }

       public RulesReadDto? GetRulesById(Guid Id)
        {
            Rule? rulesFromDb = _ruleRepo.GetRulesById(Id);  
            if (rulesFromDb == null)
            {
                return null;
            }
            return new RulesReadDto
            {
                Id = rulesFromDb.Id,
                Name = rulesFromDb.Name,
                Picture = rulesFromDb.Picture

            };
        }

        string IRulesManager.Add(RulesReadDto rules)
        {
            throw new NotImplementedException();
        }

        bool IRulesManager.Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

       

        bool IRulesManager.Update(RulesUpdateDto rules)
        {
            throw new NotImplementedException();
        }
    }
}
