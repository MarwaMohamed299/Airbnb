

namespace Airbnb.BL.Dtos.Amenity
{
    public class AmenityReadDto
    {
        public required Guid Id { get; set; }
        public required  string Name { get; set; } = string.Empty;
        public required  string Picture { get; set; } = string.Empty;
    }
}
