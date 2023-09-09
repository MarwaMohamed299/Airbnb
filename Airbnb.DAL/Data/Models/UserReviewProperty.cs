using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class UserReviewProperty
{
   
    public float Rating { get; set; }
    // Composite primary key
    [Key]
    [Column(Order = 1)]
    public string UserId { get; set; } = string.Empty;

    [Key]
    [Column(Order = 2)]
    public string PropertyId { get; set; } = string.Empty;
    [Key]
    [Column(Order = 3)]
    public Guid Id { get; set; } 

    //Nav Props
  
    public User? User { get; set; }
    public Property? Property { get; set; }
}
