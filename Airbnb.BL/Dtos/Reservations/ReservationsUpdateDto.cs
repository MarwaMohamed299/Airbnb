using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Dtos.Reservations
{
    public class ReservationsUpdateDto
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public Guid UserId { get; set; }
        public Guid PropertyId { get; set; } 
        public Guid Id { get; set; }
    }
}
