using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Dtos.Reviews
{
    public class ReviewsUpdateDto
    {
        public Guid Id { get; set; }

        public float Rating { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string PropertyId { get; set; } = string.Empty;


    }
}
