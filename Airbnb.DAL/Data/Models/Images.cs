using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class Images
{
    public Guid Id { get; set; }
    public string URL { get; set; }

    //Nav Props and FKeys

    public Guid UserId { get ; set; }   
    public Guid PropertyId { get; set; }
    public Guid AmenityId { get; set; }
    public Guid RuleId { get; set; }    

    public User User { get; set; }
    public Property Property { get; set; }
    public Amenity Amenity { get; set; }
    public Rules Rule { get; set; }
}
