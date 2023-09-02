using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class PropertyAmenity
{
    public string PropertyId { get; set; }
    public Guid AmenityId { get; set; }

    public Amenity? Amenity { get; set;}
    public Property? Property { get; set; }
}
