using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class Amenity
{
    public Guid Id { get; set; }
    public string Name { get; set; }    
    public string Picture { get; set; }

    //Nav Props 
    public ICollection<PropertyAmenity> PropertyAmenities { get; set; } = new HashSet<PropertyAmenity>();
    public Images? Img { get; set; }

}
