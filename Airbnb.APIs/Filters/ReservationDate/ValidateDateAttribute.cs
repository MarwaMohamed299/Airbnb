using Airbnb.BL.Dtos.GeneralResponse;
using Airbnb.BL.Dtos.Properties;
using Airbnb.BL.Dtos.Reservations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Airbnb.APIs.Filters.ReservationDate
{
    public class ValidateDateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ResevationsAddDto? reservationDto = context.ActionArguments["reservationDto"] as ResevationsAddDto;
            if (reservationDto == null)
            {
                context.Result = new BadRequestObjectResult(new GeneralResponse("Reservation data is missing."));
                return;
            }

            // Check if the start date is in the past
            if (reservationDto.CheckInDate < DateTime.Now)
            {
                context.Result = new BadRequestObjectResult(new GeneralResponse("Reservation start date cannot be in the past."));
                return;
            }

            // Check if the end date is before the start date
            if (reservationDto.CheckOutDate <= reservationDto.CheckInDate)
            {
                context.Result = new BadRequestObjectResult(new GeneralResponse("Invalid reservation dates. Checkout must be after check-in."));
                return;
            }
            // Check if the reservation is more than a month
            if ((reservationDto.CheckInDate - reservationDto.CheckOutDate).TotalDays > 365)
            {
                context.Result = new BadRequestObjectResult(new GeneralResponse("Reservation cannot be more than a month."));
                return;
            }

        }
    }
}
