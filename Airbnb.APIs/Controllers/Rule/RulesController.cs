using Airbnb.BL.Dtos.GeneralResponse;
using Airbnb.BL.Dtos.Properties;
using Airbnb.BL.Dtos.Rules;
using Airbnb.BL.Managers.Rules;
using Airbnb.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Airbnb.APIs.Controllers.Rule
{
    [Route("api/[controller]")]
    [ApiController]
    public class RulesController : ControllerBase
    {
        private readonly IRulesManager _rulesManager;

        public RulesController(IRulesManager rulesManager)
        {
            _rulesManager = rulesManager;
        }

        [HttpGet]
        public ActionResult <List<RulesReadDto>>GetAll()
        {
            return _rulesManager.GetAllRules().ToList();
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<RulesReadDto> GetRulesById(Guid id)
        {
            RulesReadDto? rules = _rulesManager.GetRulesById(id);
            if (rules is null)
            {
                return NotFound();
            }
            return rules;
        }
        [HttpPost]
        public ActionResult Add(RulesAddDto rulesDto)
        {
            var newId = _rulesManager.Add(rulesDto);
            return CreatedAtAction(nameof(GetRulesById),
                new { id = newId },
                new GeneralResponse("Rule Has Been Added Successfully!"));

        }

        [HttpPut]
        public ActionResult Update(RulesUpdateDto rulesDto)

        {
            var isFound = _rulesManager.Update(rulesDto);
            if (!isFound)
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(Guid id)
        {
            var isFound = _rulesManager.Delete(id);
            if (!isFound)
            {
                return NotFound();

            }
            return NoContent();
        }

    }
}
