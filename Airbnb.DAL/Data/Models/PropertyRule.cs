using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class PropertyRule
{
    public Guid RuleId { get; set; }
    public string PropertyId { get; set; }

    //Nav Props
    public Rule? Rule { get;set; }  
    public Property? Property { get; set; }
}
