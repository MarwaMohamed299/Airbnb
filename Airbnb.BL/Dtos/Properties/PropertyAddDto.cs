using Airbnb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Dtos.Properties
{
    public class PropertyAddDto
    {
        public Guid Id { get; set; }
        public PropType PropType { get; set; }
        public Guid UserID { get; set; }
        public int Country { get; set; }
        public int Governorate { get; set; }
        public string City { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int NumOfPeople { get; set; }
        public decimal PricePerNight { get; set; }
        public string Description { get; set; } = string.Empty;
     
        
}
}
