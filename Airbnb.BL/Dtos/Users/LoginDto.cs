using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Dtos.Users;

public class LoginDto
{
    public string UserName { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
}
