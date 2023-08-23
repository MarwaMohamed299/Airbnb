using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class RentContext:DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Property> Properties => Set<Property>();
    public DbSet<Amenity> Amenities => Set<Amenity>();
    public DbSet<Rules> Rules => Set<Rules>();
    public DbSet<UserReserveProperty> Reservations => Set<UserReserveProperty>();
    public DbSet<UserReviewProperty>Reviews => Set<UserReviewProperty>();
    public DbSet<PropertyAmenity> PropertyAmenities => Set<PropertyAmenity>();
    public DbSet<PropertyRule> PropertyRules => Set<PropertyRule>();    
    public DbSet<Images> Images => Set<Images>();

    public RentContext(DbContextOptions <RentContext> options):base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //User
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>().HasKey(x => x.Id);
        modelBuilder.Entity<User>().HasMany(P => P.Properties).WithOne(U => U.User).
            HasForeignKey(x => x.UserID).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<User>().HasMany(P => P.Reservations).WithOne(U => U.User).
            HasForeignKey(fk => fk.UserId).OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<User>().HasMany(R => R.Reviews).WithOne(U => U.User).
            HasForeignKey(fk => fk.UserId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<User>().HasOne(i => i.Img).WithOne(u => u.User)
            .HasForeignKey<Images>(a=>a.UserId).OnDelete(DeleteBehavior.NoAction);

        //Property
        modelBuilder.Entity<Property>().HasKey(k => k.Id);
        modelBuilder.Entity<Property>().HasMany(r=>r.Reservations).WithOne(p=>p.Property)
            .HasForeignKey(fk=>fk.PropertyId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Property>().HasMany(r => r.Reviews).WithOne(p => p.Property)
            .HasForeignKey(fk => fk.PropertyId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Property>().HasMany(pa => pa.PropertyAmenities).WithOne(p => p.Property)
            .HasForeignKey(fk => fk.PropertyId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Property>().HasMany(pr => pr.PropertyRules).WithOne(p => p.Property)
            .HasForeignKey(fk => fk.PropertyId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Property>().HasMany(i => i.Imgs).WithOne(p => p.Property).
            HasForeignKey(fk => fk.PropertyId).OnDelete(DeleteBehavior.Cascade);

        //Amenity
        modelBuilder.Entity<Amenity>().HasKey(k=> k.Id);
        modelBuilder.Entity<Amenity>().HasMany(pa => pa.PropertyAmenities).WithOne(a => a.Amenity).
            HasForeignKey(fk => fk.AmenityId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Amenity>().HasOne(img => img.Img).WithOne(a => a.Amenity)
            .HasForeignKey<Images>(a => a.AmenityId).OnDelete(DeleteBehavior.Cascade);
        //Rules
        modelBuilder.Entity<Rules>().HasKey(k => k.Id);
        modelBuilder.Entity<Rules>().HasMany(pr => pr.PropertyRules).WithOne(r => r.Rule).
            HasForeignKey(fk => fk.RuleId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Rules>().HasOne(img => img.Img).WithOne(a => a.Rule)
            .HasForeignKey<Images>(a => a.RuleId).OnDelete(DeleteBehavior.Cascade);

        //UserReserveProperty
        modelBuilder.Entity<UserReserveProperty>().HasKey(k => new { k.PropertyId, k.CheckInDate });
        //UserReviewProperty
        modelBuilder.Entity<UserReviewProperty>().HasKey(k => new {k.PropertyId, k.UserId });

        //PropertyAmenity
        modelBuilder.Entity<PropertyAmenity>().HasKey(k => new { k.PropertyId, k.AmenityId });

        //PropertyRules
        modelBuilder.Entity<PropertyRule>().HasKey(k => new { k.PropertyId, k.RuleId });

        //images
        modelBuilder.Entity<Images>().HasKey(k=>k.Id);

    }
}
