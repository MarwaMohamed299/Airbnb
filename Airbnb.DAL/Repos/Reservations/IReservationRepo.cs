

namespace Airbnb.DAL;

public interface IReservationRepo:IGenericRepo<UserReserveProperty>
{
    IEnumerable<UserReserveProperty> GetAllReservations();
    UserReserveProperty? GetReservationsByIdForUpdateAndDelete(Guid PropertyId, Guid userId);
    UserReserveProperty? GetReservationsById( Guid userId);

    void Add(UserReserveProperty userReserveProperty);
    void Update(UserReserveProperty userReserveProperty);
    void Delete(UserReserveProperty userReserveProperty);
    int SaveChanges();
}
