using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class RentContext : IdentityDbContext<User>

{
    public DbSet<Property> Properties => Set<Property>();
    public DbSet<Amenity> Amenities => Set<Amenity>();
    public DbSet<Rule> Rules => Set<Rule>();
    public DbSet<UserReserveProperty> Reservations => Set<UserReserveProperty>();
    public DbSet<UserReviewProperty> Reviews => Set<UserReviewProperty>();
    public DbSet<PropertyAmenity> PropertyAmenities => Set<PropertyAmenity>();
    public DbSet<PropertyRule> PropertyRules => Set<PropertyRule>();
    public DbSet<Image> Images => Set<Image>();

    public RentContext(DbContextOptions<RentContext> options) : base(options)
    {}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //User
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>().HasKey(x => x.Id);
        modelBuilder.Entity<User>().HasMany(P => P.Properties).WithOne(U => U.User).
            HasForeignKey(x => x.UserID).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<User>().HasMany(P => P.Reservations).WithOne(U => U.User).
            HasForeignKey(fk => fk.UserId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<User>().HasMany(R => R.Reviews).WithOne(U => U.User).
            HasForeignKey(fk => fk.UserId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<User>().HasOne(i => i.Img).WithOne(u => u.User)
            .HasForeignKey<Image>(a=>a.UserId).OnDelete(DeleteBehavior.Restrict);

        //Property
        modelBuilder.Entity<Property>().HasKey(k => k.Id);
        modelBuilder.Entity<Property>().HasMany(r=>r.Reservations).WithOne(p=>p.Property)
            .HasForeignKey(fk=>fk.PropertyId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Property>().HasMany(r => r.Reviews).WithOne(p => p.Property)
            .HasForeignKey(fk => fk.PropertyId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Property>().HasMany(pa => pa.PropertyAmenities).WithOne(p => p.Property)
            .HasForeignKey(fk => fk.PropertyId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Property>().HasMany(pr => pr.PropertyRules).WithOne(p => p.Property)
            .HasForeignKey(fk => fk.PropertyId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Property>().HasMany(i => i.Imgs).WithOne(p => p.Property).
            HasForeignKey(fk => fk.PropertyId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Property>().Property(p => p.PricePerNight).HasColumnType("decimal(18,2)");

        //Amenity
        modelBuilder.Entity<Amenity>().HasKey(k=> k.Id);
        modelBuilder.Entity<Amenity>().HasMany(pa => pa.PropertyAmenities).WithOne(a => a.Amenity).
            HasForeignKey(fk => fk.AmenityId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Amenity>().HasOne(img => img.Img).WithOne(a => a.Amenity)
            .HasForeignKey<Image>(a => a.AmenityId).OnDelete(DeleteBehavior.Cascade);
        //Rules
        modelBuilder.Entity<Rule>().HasKey(k => k.Id);
        modelBuilder.Entity<Rule>().HasMany(pr => pr.PropertyRules).WithOne(r => r.Rule).
            HasForeignKey(fk => fk.RuleId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Rule>().HasOne(img => img.Img).WithOne(a => a.Rule)
            .HasForeignKey<Image>(a => a.RuleId).OnDelete(DeleteBehavior.Cascade);

        //UserReserveProperty
        modelBuilder.Entity<UserReserveProperty>().HasKey(k => new { k.Id });
        
        //UserReviewProperty
        modelBuilder.Entity<UserReviewProperty>().HasKey(k => new {k.PropertyId, k.UserId ,k.Id});

        //PropertyAmenity
        modelBuilder.Entity<PropertyAmenity>().HasKey(k => new { k.PropertyId, k.AmenityId });

        //PropertyRules
        modelBuilder.Entity<PropertyRule>().HasKey(k => new { k.PropertyId, k.RuleId });

        //images
        modelBuilder.Entity<Image>().HasKey(k=>k.Id);


        #region Seeding 


        var users = new List<User>
{
    new User
    {
        Id = Guid.NewGuid().ToString(),
        UserRole = Role.Guest,
        FName = "John",
        LName = "Doe",
        Email = "john.doe@example.com",
        Password = "password123",
        UserName = "johndoe",
        PhoneNumber = "123456789",
        Country = 1,
        Governorate = 2,
        City = "New York",
        CreationDate = DateTime.Now
    },
    new User
    {
        Id = Guid.NewGuid().ToString(),
        UserRole = Role.Guest,
        FName = "Jane",
        LName = "Doe",
        Email = "jane.doe@example.com",
        Password = "password123",
        UserName = "janedoe",
        PhoneNumber = "987654321",
        Country = 2,
        Governorate = 3,
        City = "Los Angeles",
        CreationDate = DateTime.Now
    },
    new User
    {
        Id = Guid.NewGuid().ToString(),
        UserRole = Role.Guest,
        FName = "Michael",
        LName = "Smith",
        Email = "michael.smith@example.com",
        Password = "password123",
        UserName = "michaelsmith",
        PhoneNumber = "321456789",
        Country = 3,
        Governorate = 4,
        City = "London",
        CreationDate = DateTime.Now
    },
        new User
    {
        Id = Guid.NewGuid().ToString(),
        UserRole = Role.Guest,
        FName = "David",
        LName = "Williams",
        Email = "david.williams@example.com",
        Password = "password123",
        UserName = "davidwilliams",
        PhoneNumber = "765432109",
        Country = 4,
        Governorate = 5,
        City = "Paris",
        CreationDate = DateTime.Now
    },
    new User
    {
        Id = Guid.NewGuid().ToString(),
        UserRole = Role.Host,
        FName = "Elizabeth",
        LName = "Brown",
        Email = "elizabeth.brown@example.com",
        Password = "password123",
        UserName = "elizabethbrown",
        PhoneNumber = "543210987",
        Country = 5,
        Governorate = 6,
        City = "Rome",
        CreationDate = DateTime.Now
    },
    new User
    {
        Id = Guid.NewGuid().ToString(),
        UserRole = Role.Guest,
        FName = "Thomas",
        LName = "Anderson",
        Email = "thomas.anderson@example.com",
        Password = "password123",
        UserName = "thomasanderson",
        PhoneNumber = "987654321",
        Country = 6,
        Governorate = 7,
        City = "Tokyo",
        CreationDate = DateTime.Now
    },
      new User
    {
        Id = Guid.NewGuid().ToString(),
        UserRole = Role.Guest,
        FName = "Jasmin",
        LName = "Anderson",
        Email = "Jasmine.anderson@example.com",
        Password = "password123",
        UserName = "jasmineanderson",
        PhoneNumber = "987654321",
        Country = 6,
        Governorate = 2,
        City = "Boston",
        CreationDate = DateTime.Now
    },
        new User
    {
        Id = Guid.NewGuid().ToString(),
        UserRole = Role.Guest,
        FName = "Sara",
        LName = "zukerberg",
        Email = "sara.zuckerberg@example.com",
        Password = "password143",
        UserName = "sara.zuckerberg",
        PhoneNumber = "987654321",
        Country = 2,
        Governorate = 7,
        City = "Texas",
        CreationDate = DateTime.Now
    },
    };

        var properties = new List<Property>
{
    new Property
    {
        Id = Guid.NewGuid().ToString(),
        PropType = PropType.Apartment,
        Country = (Data.DataTypes.Country)2,
        Governorate = 2,
        City = "New York",
        CreationDate = DateTime.Now,
        NumOfPeople = 4,
        PricePerNight = 100,
        Description = "Beautiful apartment in the heart of the city",
        UserID = users[0].Id // Assign the ID of the user as the UserID
    },
    new Property
    {
        Id = Guid.NewGuid().ToString(),
        PropType = PropType.Villa,
        Country = (Data.DataTypes.Country)1,
        Governorate = 3,
        City = "Los Angeles",
        CreationDate = DateTime.Now,
        NumOfPeople = 6,
        PricePerNight = 200,
        Description = "Luxurious villa with a pool and garden",
        UserID =(users[1].Id)
    },
    new Property
    {
        Id = Guid.NewGuid().ToString(),
        PropType = PropType.Cabin,
        Country = (Data.DataTypes.Country)2,
        Governorate = 4,
        City = "London",
        CreationDate = DateTime.Now,
        NumOfPeople = 2,
        PricePerNight = 150,
        Description = "Cozy cottage by the beach",
        UserID =(users[2].Id)
    },
      new Property
    {
        Id = Guid.NewGuid().ToString(),
        PropType = PropType.Room,
        Country = (Data.DataTypes.Country)2,
        Governorate = 5,
        City = "Paris",
        CreationDate = DateTime.Now,
        NumOfPeople = 1,
        PricePerNight = 50,
        Description = "Cozy studio apartment in the city center",
        UserID = (users[3].Id)
    },
    new Property
    {
        Id = Guid.NewGuid().ToString(),
        PropType = PropType.Cabin,
        Country = (Data.DataTypes.Country)3,
        Governorate = 6,
        City = "Rome",
        CreationDate = DateTime.Now,
        NumOfPeople = 4,
        PricePerNight = 100,
        Description = "Wooden cabin in the woods",
        UserID =(users[4].Id)
    },
    new Property
    {
        Id = Guid.NewGuid().ToString(),
        PropType = PropType.Duplex,
        Country = (Data.DataTypes.Country)1,
        Governorate = 7,
        City = "Tokyo",
        CreationDate = DateTime.Now,
        NumOfPeople = 6,
        PricePerNight = 200,
        Description = "Luxurious penthouse with a view",
        UserID =(users[5].Id)
    },
      new Property
    {
        Id = Guid.NewGuid().ToString(),
        PropType = PropType.Duplex,
        Country = (Data.DataTypes.Country)2,
        Governorate = 7,
        City = "Texas",
        CreationDate = DateTime.Now,
        NumOfPeople = 6,
        PricePerNight = 200,
        Description = "Luxurious penthouse with a view",
        UserID =(users[6].Id)
    },
    // Add more properties here...
};
        var Amenities = new List<Amenity>
        {
            new Amenity
            {
               Id = Guid.NewGuid(),
               Name = " wi-fi ",
               Picture = "1.jpg"

            },
            new Amenity
            {
               Id = Guid.NewGuid(),
               Name = " Conditioner ",
               Picture = "2.jpg"

            },new Amenity
            {
               Id = Guid.NewGuid(),
               Name = " Iron ",
               Picture = "3.jpg"

            },new Amenity
            {
               Id = Guid.NewGuid(),
               Name = " Swimming Pool ",
               Picture = "4.jpg"

            },new Amenity
            {
               Id = Guid.NewGuid(),
               Name = " washing machine",
               Picture = "5.jpg"

            },
        };
        var Images = new List<Image>
            {
                new Image
                {
                    Id = Guid.NewGuid(),
                    URL = "1.jpg"
                },
                  new Image
                {
                    Id = Guid.NewGuid(),
                    URL = "2.jpg"
                },  new Image
                {
                    Id = Guid.NewGuid(),
                    URL = "3.jpg"
                },  new Image
                {
                    Id = Guid.NewGuid(),
                    URL = "4.jpg"
                },  new Image
                {
                    Id = Guid.NewGuid(),
                    URL = "5.jpg"
                },  new Image
                {
                    Id = Guid.NewGuid(),
                    URL = "6.jpg"
                },
            };
        var Reservations = new List<UserReserveProperty>
            {
            new UserReserveProperty
            {
                 Id = Guid.NewGuid(),
                CheckInDate = new DateTime(2023, 9, 10),
                CheckOutDate = new DateTime(2023, 9, 15),
                UserId = (users[5].Id),
                PropertyId = (properties[3].Id)

            },   new UserReserveProperty
            {
                 Id = Guid.NewGuid(),
                CheckInDate = new DateTime(2023, 5, 10),
                CheckOutDate = new DateTime(2023, 8, 15),
                UserId = (users[2].Id),
                PropertyId = (properties[6].Id)

            },   new UserReserveProperty
            {
                 Id = Guid.NewGuid(),
                CheckInDate = new DateTime(2023, 9, 10),
                CheckOutDate = new DateTime(2023, 7, 22),
                UserId = (users[1].Id),
                PropertyId = (properties[5].Id)

            },   new UserReserveProperty
            {
                 Id = Guid.NewGuid(),
                CheckInDate = new DateTime(2023, 1, 10),
                CheckOutDate = new DateTime(2023, 12, 15),
                UserId = (users[4].Id),
                PropertyId = (properties[1].Id)

            },
};
        var Reviews = new List<UserReviewProperty>
        {
            new UserReviewProperty
        {
                Id= Guid.NewGuid(),
                Rating = 2.3f,
                UserId = (users[2].Id),
                PropertyId = (properties[1].Id),
         },     new UserReviewProperty
        {
                Id= Guid.NewGuid(),
                Rating = 1.2f,
                UserId = (users[1].Id),
                PropertyId = (properties[2].Id),
         },     new UserReviewProperty
        {

                Id= Guid.NewGuid(),
                Rating = 4.5f,
                UserId = (users[3].Id),
                PropertyId = (properties[4].Id),
         },     new UserReviewProperty
        {
                Id= Guid.NewGuid(),
                Rating = 4.5f,
                UserId = (users[4].Id),
                PropertyId = (properties[3].Id),
         },     new UserReviewProperty
        {
                Id= Guid.NewGuid(),
                Rating = 4.5f,
                UserId = (users[5].Id),
                PropertyId = (properties[5].Id),
         },

    };

        var Rules = new List<Rule>
        {
            new Rule{
            Id = Guid.NewGuid(),
            Name = "No Smoking",
            Picture = "smoking.jpg"
            },
             new Rule{
            Id = Guid.NewGuid(),
            Name = "No Smoking",
            Picture = "smoking.jpg"
            },
              new Rule{
            Id = Guid.NewGuid(),
            Name = "No Smoking",
            Picture = "smoking.jpg"
            },
               new Rule{
            Id = Guid.NewGuid(),
            Name = "No Smoking",
            Picture = "smoking.jpg"
            },
                new Rule{
            Id = Guid.NewGuid(),
            Name = "No Smoking",
            Picture = "smoking.jpg"
            },
                 new Rule{
            Id = Guid.NewGuid(),
            Name = "No Smoking",
            Picture = "smoking.jpg"
            }
                 };




        modelBuilder.Entity<Property>().HasData(properties);
        modelBuilder.Entity<User>().HasData(users);
        modelBuilder.Entity<Amenity>().HasData(Amenities);
        modelBuilder.Entity<Image>().HasData(Images);
        modelBuilder.Entity<UserReserveProperty>().HasData(Reservations);
        modelBuilder.Entity<UserReviewProperty>().HasData(Reviews);
        modelBuilder.Entity<Rule>().HasData(Rules);






    }
    #endregion
}
