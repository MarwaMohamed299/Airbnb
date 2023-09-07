using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Dtos.Reviews
{
    public class ReviewsUpdateDto
    {
        public float Rating { get; set; }
        public Guid UserId { get; set; }
        public Guid PropertyId { get; set; }


    }
}
