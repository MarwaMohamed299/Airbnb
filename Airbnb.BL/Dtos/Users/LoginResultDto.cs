using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL;

public class LoginResultDto
{
    public bool Success { get; set; }
    public string? Message { get; set; } 
    public string? Token { get; set; }
    public DateTime? ExpiryDate { get; set; }
}
