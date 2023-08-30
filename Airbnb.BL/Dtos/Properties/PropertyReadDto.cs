using Airbnb.DAL;

namespace Airbnb.APIs.Dtos.Properties
{
    public class PropertyReadDto
    {
        public Guid Id { get; set; }
        public PropType PropType { get; set; }
        public int Country { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.Now;
        public int Governorate { get; set; }
        public string City { get; set; }
        public int NumOfPeople { get; set; }
        public decimal PricePerNight { get; set; }
        public string Description { get; set; }
      
    }
}

