

namespace Airbnb.DAL;

public interface IAmenityRepo:IGenericRepo<Amenity>
{
    IEnumerable<Amenity> GetAll();
    Amenity? GetAmenityById(Guid Id);
    void Add(Amenity amenity);
    void Update(Amenity amenity);
    void Delete(Amenity amenity);
    int SaveChanges();
    Amenity? GetAmenityByIdForUpdateAndDelete(Guid Id, Guid propertyId);
}
