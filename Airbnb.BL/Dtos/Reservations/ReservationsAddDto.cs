using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Dtos.Reservations
{
    public class ReservationsAddDto
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string PropertyId { get; set; } = string.Empty;
    }
}
