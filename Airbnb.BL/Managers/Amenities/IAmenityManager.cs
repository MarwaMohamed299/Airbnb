using Airbnb.BL.Dtos.Amenities;


namespace Airbnb.BL.Managers.Amenities
{
    public interface IAmenityManager
    {
        IEnumerable<AmenityReadDto> GetAll();
        AmenityReadDto? GetAmenityById(Guid Id);
        System.Guid Add(AmenityAddDto amenity);
        bool Update(AmenityUpdateDto amenity);
        bool Delete(Guid Id , Guid PropertyId);


    }
}
