using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Dtos.GeneralResponse
{
    public class GeneralResponse
    {
        public string Message { set; get; } = string.Empty;

        public GeneralResponse (string message)
        {
            Message = message;
        }
    }
}
