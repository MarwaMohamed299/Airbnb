using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class ReservationRepo : GenericRepo<UserReserveProperty>, IReservationRepo
{
    private readonly RentContext _rentContext;

    public ReservationRepo(RentContext rentContext):base(rentContext)
    {
        _rentContext = rentContext;
    }

    public IEnumerable<UserReserveProperty> GetAllReservations()  //GetAll
    {
        return _rentContext.Set<UserReserveProperty>().ToList();
    }

    public UserReserveProperty? GetReservationsById(Guid Id)    //GetById
    {
        return _rentContext.Set<UserReserveProperty>().Find();
    }
    public void Add(UserReserveProperty userReserveProperty)    //Add
    {
         _rentContext.Set<UserReserveProperty>().Add(userReserveProperty);

    }

    public void Update(UserReserveProperty userReserveProperty)    //update
    {
    }
    public void Delete(UserReserveProperty userReserveProperty)    //Delete
    {

        _rentContext.Set<UserReserveProperty>().Remove(userReserveProperty);
    }



    int IReservationRepo.SaveChanges()        //save changes
    {
        return _rentContext.SaveChanges();
    }

   //public UserReserveProperty? GetReservationsByIdForUpdateAndDelete(Guid PropertyId, Guid userId)
   // {
   //     return _rentContext.Set<UserReserveProperty>().Find();
   // }
}
