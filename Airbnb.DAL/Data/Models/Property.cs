﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class Property
{
    public Guid Id { get; set; }
    public PropType PropType { get; set; }
    public int Country { get; set; }
    public int Governorate { get; set; }
    public string City { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public int NumOfPeople { get; set; }
    public decimal PricePerNight { get; set; }  
    public string Description { get; set; } 
    //Nav Props
    public Guid UserID { get; set; }
    public User User { get; set; }
    public ICollection<UserReserveProperty> Reservations { get; set; } = new HashSet<UserReserveProperty>();
    public ICollection<UserReviewProperty> Reviews { get; set; } = new HashSet<UserReviewProperty>();
    public ICollection<PropertyAmenity> PropertyAmenities{ get; set; } = new HashSet<PropertyAmenity>();
    public ICollection<PropertyRule> PropertyRules{ get; set; } = new HashSet<PropertyRule>();
    public ICollection<Images> Imgs { get; set; }= new HashSet<Images>();
}
 