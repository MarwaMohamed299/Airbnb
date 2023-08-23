using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class Rules
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Picture { get; set; }

    //navprops
    public ICollection<PropertyRule> PropertyRules { get; set; }=new HashSet<PropertyRule>();
    public Images? Img { get; set; }

}
