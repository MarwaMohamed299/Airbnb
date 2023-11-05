using Airbnb.BL.Dtos.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Managers.Reservations
{
    public interface IReservationsManager
    {
        IEnumerable<ReservationsReadDto> GetAllReservations();
        ReservationsReadDto? GetReservationsById(Guid Id);
        string Add(ResevationsAddDto reservations);
        bool Update(ReservationsUpdateDto reservations);
        bool Delete(Guid Id);
    }
}
