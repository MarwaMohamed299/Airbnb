using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Dtos.Images
{
    public class ImagesAddDto
    {
        public required Guid Id { get; set; }
        public required string URL { get; set; } = string.Empty; 
    }
}
