using Airbnb.BL.Dtos.GeneralResponse;
using Airbnb.BL.Dtos.Reservations;
using Airbnb.BL.Dtos.Rules;
using Airbnb.BL.Managers.Reservations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airbnb.APIs.Controllers.Reservation
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationsManager _reservationManager;

        public ReservationController(IReservationsManager reservationManager)
        {
            _reservationManager = reservationManager;
        }
        [HttpGet]
        public ActionResult<List<ReservationsReadDto>> GetAll()
        {
            return _reservationManager.GetAllReservations().ToList();
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<ReservationsReadDto> GetReservationsById(Guid id)
        {
            ReservationsReadDto? reservations = _reservationManager.GetReservationsById(id);
            if (reservations is null)
            {
                return NotFound();
            }
            return reservations;
        }
        [HttpPost]
        public ActionResult Add(ResevationsAddDto reservationsDto)
        {
            var newId = _reservationManager.Add(reservationsDto);
            return CreatedAtAction(nameof(GetReservationsById),
                new { id = newId },
                new GeneralResponse("Reservation Has Been Added Successfully!"));

        }

        [HttpPut]
        public ActionResult Update(ReservationsUpdateDto reservationDto)

        {
            var isFound = _reservationManager.Update(reservationDto);
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
            var isFound = _reservationManager.Delete( id);
            if (!isFound)
            {
                return NotFound();

            }
            return NoContent();
        }
     
    }
}
