
namespace Airbnb.BL.Dtos.Amenities
{
    public class AmenityUpdateDto
    {
        internal readonly Guid Id;

        public required string Name { get; set; } = string.Empty;
        public required string Picture { get; set; } = string.Empty;
    }
}
