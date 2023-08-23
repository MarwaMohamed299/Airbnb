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
    public string FName { get; set; }
    public string LName { get; set; }   
    public string Email { get; set; }   
    public string Password { get; set; }    
    public string UserName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; }
    public int Country { get; set; }
    public int Governorate { get; set; }
    public string City { get; set; }
    public DateTime CreationDate { get; set; }= DateTime.Now;

    //Nav Properties 
    public ICollection<Property> Properties { get; set; }=new HashSet<Property>();
    public ICollection<UserReserveProperty> Reservations { get; set; }=new HashSet<UserReserveProperty>();    
    public ICollection<UserReviewProperty> Reviews { get; set; }=new HashSet<UserReviewProperty>();
    public Images? Img { get; set; }
}
