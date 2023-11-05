using Airbnb.BL.Dtos.GeneralResponse;
using Airbnb.BL.Dtos.Properties;
using Airbnb.DAL.Data.DataTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


using Property = Airbnb.DAL.Property;

namespace Airbnb.APIs.Filters
{
    public class ValidateCountryAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ResevationAddDto? propertyDto = context.ActionArguments["propertyDto"] as ResevationAddDto;

            var allowedCountries = new Country[]
            {
                Country.EGY,
                Country.UAE,
                Country.USA
            };

            if (propertyDto is null || !allowedCountries.Contains(propertyDto.Country))
            {
                context.Result = new BadRequestObjectResult(new GeneralResponse("Country is NOT covered"));
            }
        }
    }
}
