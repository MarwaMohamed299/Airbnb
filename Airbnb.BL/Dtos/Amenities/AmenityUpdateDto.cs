
namespace Airbnb.BL.Dtos.Amenities
{
    public class AmenityUpdateDto
    {
        public required Guid Id { get; set; }
      

        public required string Name { get; set; } = string.Empty;
        public required string Picture { get; set; } = string.Empty;
    }
}
