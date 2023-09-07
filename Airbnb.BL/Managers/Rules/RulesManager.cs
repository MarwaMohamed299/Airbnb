using Airbnb.BL.Dtos.Reviews;
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

        public string Add(RulesAddDto rulesFromRequest)
        {
            Rule? rules = new Rule
            {
                 Name=rulesFromRequest.Name,
                 Picture = rulesFromRequest.Picture
            };
            _ruleRepo.Add(rules);
            _ruleRepo.SaveChanges();
            return rules.Id.ToString();
        }

        public bool Update(RulesUpdateDto rulesFromRequest)
        {
            Rule? rules = _ruleRepo.GetRulesByIdForUpdateAndDelete(rulesFromRequest.PropertyId, rulesFromRequest.UserId);
            rules.Name = rulesFromRequest.Name;
            rules.Picture = rulesFromRequest.Picture;
            _ruleRepo.Update(rules);
            _ruleRepo.SaveChanges();
            return true;
        }
        public bool Delete(Guid propertyId, Guid userId)
        {
           Rule? rules = _ruleRepo.GetRulesByIdForUpdateAndDelete(propertyId, userId);
            if (rules == null)
            {
                return false;
            }
            _ruleRepo.Delete(rules);
            _ruleRepo.SaveChanges();
            return true;
        }

      
    }
}

