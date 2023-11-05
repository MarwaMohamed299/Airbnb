using Airbnb.DAL.Data.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class Property
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public PropType PropType { get; set; }
    public Country Country { get; set; }
    public int Governorate { get; set; }
    public string City { get; set; } = string.Empty;
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public int NumOfPeople { get; set; }
    public decimal PricePerNight { get; set; }  
    public string Description { get; set; } = string.Empty;
    //Nav Props
    public string UserID { get; set; }
    public User? User { get; set; }
    public ICollection<UserReserveProperty> Reservations { get; set; } = new HashSet<UserReserveProperty>();
    public ICollection<UserReviewProperty> Reviews { get; set; } = new HashSet<UserReviewProperty>();
    public ICollection<PropertyAmenity> PropertyAmenities{ get; set; } = new HashSet<PropertyAmenity>();
    public ICollection<PropertyRule> PropertyRules{ get; set; } = new HashSet<PropertyRule>();
    public ICollection<Image> Imgs { get; set; }= new HashSet<Image>();
}
 