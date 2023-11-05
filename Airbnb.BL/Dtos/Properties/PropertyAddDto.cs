using Airbnb.DAL;
using Airbnb.DAL.Data.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Dtos.Properties
{
    public class ResevationAddDto
    {
        public PropType PropType { get; set; }
        public string UserID { get; set; } = string.Empty;
        public Country Country { get; set; }
        public int Governorate { get; set; }
        public string City { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int NumOfPeople { get; set; }
        public decimal PricePerNight { get; set; }
        public string Description { get; set; } = string.Empty;
     
        
}
}
