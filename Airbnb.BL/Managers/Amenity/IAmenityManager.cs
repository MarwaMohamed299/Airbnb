using Airbnb.BL.Dtos.Amenity;


namespace Airbnb.BL.Managers.Amenity
{
    public interface IAmenityManager
    {
        IEnumerable<AmenityReadDto> GetAll();
        AmenityReadDto? GetAmenityById();
        System.Guid Add(AmenityAddDto amenity);
        bool Update(AmenityUpdateDto amenity);
        bool Delete(Guid Id);


    }
}
