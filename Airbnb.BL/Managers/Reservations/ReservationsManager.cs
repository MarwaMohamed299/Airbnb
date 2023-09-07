using Airbnb.BL.Dtos.Reservations;
using Airbnb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Managers.Reservations
{
    public class ReservationsManager : IReservationsManager
    {
        private readonly IReservationRepo _reservationsRepo;

        public ReservationsManager(IReservationRepo reservationsRepo)
        {
            _reservationsRepo = reservationsRepo;
        }
        public IEnumerable<ReservationsReadDto> GetAllReservations()            //GetAll
        {
            IEnumerable<UserReserveProperty> reservationsFromDb = _reservationsRepo.GetAllReservations();
            return reservationsFromDb.Select(r => new ReservationsReadDto
            {
                CheckInDate = r.CheckInDate,
                CheckOutDate = r.CheckOutDate
            });

        }

        public ReservationsReadDto? GetReservationsById(Guid Id)                //GetById
        {
            UserReserveProperty? reservationsFromDb = _reservationsRepo.GetReservationsById(Id);
            if (reservationsFromDb == null)
            {
                return null;
            }
            return new ReservationsReadDto
            {
                CheckInDate = reservationsFromDb.CheckInDate,
                CheckOutDate = reservationsFromDb.CheckOutDate
            };
        }
        public string Add(ReservationsAddDto reservationsFromRequest)                      //Add
        {
            UserReserveProperty? userReserveProperty = new UserReserveProperty
            {
                CheckInDate = reservationsFromRequest.CheckInDate,
                CheckOutDate = reservationsFromRequest.CheckOutDate

            };
            _reservationsRepo.Add(userReserveProperty);
            _reservationsRepo.SaveChanges();
            return reservationsFromRequest.UserId;
        }
     

        public bool Update(ReservationsUpdateDto reservationsFromRequest)
        {
            UserReserveProperty? reservation = _reservationsRepo.GetReservationsById(reservationsFromRequest.Id);
            if (reservation == null)
            {
                return false;
            }
            reservation.CheckInDate = reservationsFromRequest.CheckInDate;
            reservation.CheckOutDate = reservationsFromRequest.CheckOutDate;
            _reservationsRepo.Update(reservation);
            _reservationsRepo.SaveChanges();
            return true;
        }

        public bool Delete(Guid Id)
        {
            UserReserveProperty? reservation = _reservationsRepo.GetReservationsById(Id);
            if (reservation == null)
            {
                return false;
            }
            _reservationsRepo.Delete(reservation);
            _reservationsRepo.SaveChanges();
            return true;
        }


    }
}
