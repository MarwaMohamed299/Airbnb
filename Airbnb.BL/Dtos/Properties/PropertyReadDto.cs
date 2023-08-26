using Airbnb.DAL;

namespace Airbnb.APIs.Dtos.Properties
{
    public class PropertyReadDto
    {
        public Guid Id { get; set; }
        public PropType PropType { get; set; }
        public int Country { get; set; }
        public int Governorate { get; set; }
        public string City { get; set; }
        public int NumOfPeople { get; set; }
        public decimal PricePerNight { get; set; }
        public string Description { get; set; }
        //Nav Props
 
        public ICollection<UserReserveProperty> Reservations { get; set; } = new HashSet<UserReserveProperty>();
        public ICollection<UserReviewProperty> Reviews { get; set; } = new HashSet<UserReviewProperty>();
        public ICollection<PropertyAmenity> PropertyAmenities { get; set; } = new HashSet<PropertyAmenity>();
        public ICollection<PropertyRule> PropertyRules { get; set; } = new HashSet<PropertyRule>();
        public ICollection<Images> Imgs { get; set; } = new HashSet<Images>();
    }
}

