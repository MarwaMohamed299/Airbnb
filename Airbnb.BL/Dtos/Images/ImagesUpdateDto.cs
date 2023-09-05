using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Dtos.Images
{
    public class ImagesUpdateDto
    {
        public Guid Id { get; }
        public string URL { get; set; } = string.Empty;
    }
}
