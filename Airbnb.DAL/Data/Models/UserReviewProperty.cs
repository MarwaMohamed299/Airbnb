﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class UserReviewProperty
{
   
    public float Rating { get; set; }

    //Nav Props
    public Guid UserId { get; set; }
    public Guid PropertyId { get; set; }
    public User User { get; set; }
    public Property Property { get; set; }
}
