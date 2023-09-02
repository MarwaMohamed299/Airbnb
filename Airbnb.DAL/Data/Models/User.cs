using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;
public class User
{
    public Guid Id { get; set; }
    public Role UserRole { get; set; } = Role.Guest;
    public string FName { get; set; } = string.Empty;
    public string LName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public int Country { get; set; }
    public int Governorate { get; set; }
    public string City { get; set; } = string.Empty;
    public DateTime CreationDate { get; set; }= DateTime.Now;

    //Nav Properties 
    public ICollection<Property> Properties { get; set; }=new HashSet<Property>();
    public ICollection<UserReserveProperty> Reservations { get; set; }=new HashSet<UserReserveProperty>();    
    public ICollection<UserReviewProperty> Reviews { get; set; }=new HashSet<UserReviewProperty>();
    public Images? Img { get; set; }
}
