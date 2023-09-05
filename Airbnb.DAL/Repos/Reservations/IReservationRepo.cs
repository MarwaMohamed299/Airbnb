

namespace Airbnb.DAL;

public interface IReservationRepo:IGenericRepo<UserReserveProperty>
{
    IEnumerable<UserReserveProperty> GetAllReservations();
    UserReserveProperty? GetReservationsById(Guid Id);
    void Add(UserReserveProperty userReserveProperty);
    void Update(UserReserveProperty userReserveProperty);
    void Delete(UserReserveProperty userReserveProperty);
    int SaveChanges();
}
