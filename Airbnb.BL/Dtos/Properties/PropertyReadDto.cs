using Airbnb.DAL;
using Airbnb.DAL.Data.DataTypes;

namespace Airbnb
{
    public class PropertyReadDto
    {
        public string Id { get; set; } 
        public PropType PropType { get; set; }
        public string UserID { get; set; } = string.Empty;
        public Country Country { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int Governorate { get; set; }
        public string City { get; set; } = string.Empty;
        public int NumOfPeople { get; set; }
        public decimal PricePerNight { get; set; }
        public string Description { get; set; } = string.Empty;
    
    }
}

