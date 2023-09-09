using Airbnb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Dtos.Properties
{
    public class PropertyUpdateDto
    {
        public string Id { get; set; }
        public PropType PropType { get; set; }
        public string UserID { get; set; } = string.Empty;

        public int Country { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int Governorate { get; set; }
        public string City { get; set; } = string.Empty;
        public int NumOfPeople { get; set; }
        public decimal PricePerNight { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
