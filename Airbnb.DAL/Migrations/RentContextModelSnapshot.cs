﻿// <auto-generated />
using System;
using Airbnb.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Airbnb.DAL.Migrations
{
    [DbContext(typeof(RentContext))]
    partial class RentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Airbnb.DAL.Amenity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Amenities");
                });

            modelBuilder.Entity("Airbnb.DAL.Images", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AmenityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PropertyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("RuleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AmenityId")
                        .IsUnique()
                        .HasFilter("[AmenityId] IS NOT NULL");

                    b.HasIndex("PropertyId");

                    b.HasIndex("RuleId")
                        .IsUnique()
                        .HasFilter("[RuleId] IS NOT NULL");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Airbnb.DAL.Property", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Governorate")
                        .HasColumnType("int");

                    b.Property<int>("NumOfPeople")
                        .HasColumnType("int");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PropType")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = "c519065e-4bcf-4fb7-8978-d6d02ab86f6e",
                            City = "New York",
                            Country = 1,
                            CreationDate = new DateTime(2023, 9, 2, 18, 21, 48, 343, DateTimeKind.Local).AddTicks(1579),
                            Description = "Beautiful apartment in the heart of the city",
                            Governorate = 2,
                            NumOfPeople = 4,
                            PricePerNight = 100m,
                            PropType = 0,
                            UserID = "f5c999d7-824f-4252-9f0c-dedb1d932065"
                        },
                        new
                        {
                            Id = "f2e19869-0394-4cb6-a6f7-bf91ec7a90ef",
                            City = "Los Angeles",
                            Country = 2,
                            CreationDate = new DateTime(2023, 9, 2, 18, 21, 48, 343, DateTimeKind.Local).AddTicks(1592),
                            Description = "Luxurious villa with a pool and garden",
                            Governorate = 3,
                            NumOfPeople = 6,
                            PricePerNight = 200m,
                            PropType = 1,
                            UserID = "8627c943-b0b3-415f-b872-416b875a64d6"
                        },
                        new
                        {
                            Id = "8cb57124-196a-42af-aa0d-e142ff96c2e9",
                            City = "London",
                            Country = 3,
                            CreationDate = new DateTime(2023, 9, 2, 18, 21, 48, 343, DateTimeKind.Local).AddTicks(1605),
                            Description = "Cozy cottage by the beach",
                            Governorate = 4,
                            NumOfPeople = 2,
                            PricePerNight = 150m,
                            PropType = 2,
                            UserID = "26a6d6a2-2fc2-4c75-907d-d4d9430b5e76"
                        },
                        new
                        {
                            Id = "ced3d5e9-71d7-409a-ba59-2f303a43b892",
                            City = "Paris",
                            Country = 4,
                            CreationDate = new DateTime(2023, 9, 2, 18, 21, 48, 343, DateTimeKind.Local).AddTicks(1614),
                            Description = "Cozy studio apartment in the city center",
                            Governorate = 5,
                            NumOfPeople = 1,
                            PricePerNight = 50m,
                            PropType = 4,
                            UserID = "8c4fefdd-75a9-497f-91a8-e8eb537135c6"
                        },
                        new
                        {
                            Id = "d71ed516-0896-4605-a761-eab2fe00b319",
                            City = "Rome",
                            Country = 5,
                            CreationDate = new DateTime(2023, 9, 2, 18, 21, 48, 343, DateTimeKind.Local).AddTicks(1624),
                            Description = "Wooden cabin in the woods",
                            Governorate = 6,
                            NumOfPeople = 4,
                            PricePerNight = 100m,
                            PropType = 2,
                            UserID = "8d230bcb-716a-46db-b1ab-0fba86fac50b"
                        },
                        new
                        {
                            Id = "5df202b1-71dd-4d50-b6cf-24380efee546",
                            City = "Tokyo",
                            Country = 6,
                            CreationDate = new DateTime(2023, 9, 2, 18, 21, 48, 343, DateTimeKind.Local).AddTicks(1633),
                            Description = "Luxurious penthouse with a view",
                            Governorate = 7,
                            NumOfPeople = 6,
                            PricePerNight = 200m,
                            PropType = 3,
                            UserID = "ec41f813-d16c-482c-9fd9-f70b8b149486"
                        });
                });

            modelBuilder.Entity("Airbnb.DAL.PropertyAmenity", b =>
                {
                    b.Property<string>("PropertyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("AmenityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PropertyId", "AmenityId");

                    b.HasIndex("AmenityId");

                    b.ToTable("PropertyAmenities");
                });

            modelBuilder.Entity("Airbnb.DAL.PropertyRule", b =>
                {
                    b.Property<string>("PropertyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("RuleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PropertyId", "RuleId");

                    b.HasIndex("RuleId");

                    b.ToTable("PropertyRules");
                });

            modelBuilder.Entity("Airbnb.DAL.Rules", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("Airbnb.DAL.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Governorate")
                        .HasColumnType("int");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "f5c999d7-824f-4252-9f0c-dedb1d932065",
                            AccessFailedCount = 0,
                            City = "New York",
                            ConcurrencyStamp = "33cdb605-5252-4add-bd92-5b23f9d91779",
                            Country = 1,
                            CreationDate = new DateTime(2023, 9, 2, 18, 21, 48, 343, DateTimeKind.Local).AddTicks(1443),
                            Email = "john.doe@example.com",
                            EmailConfirmed = false,
                            FName = "John",
                            Governorate = 2,
                            LName = "Doe",
                            LockoutEnabled = false,
                            Password = "password123",
                            PhoneNumber = "123456789",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6bbd656c-9855-45f5-8172-0385afab9610",
                            TwoFactorEnabled = false,
                            UserName = "johndoe",
                            UserRole = 0
                        },
                        new
                        {
                            Id = "8627c943-b0b3-415f-b872-416b875a64d6",
                            AccessFailedCount = 0,
                            City = "Los Angeles",
                            ConcurrencyStamp = "2dd87695-3456-4d25-99c6-0f9ab1cc30af",
                            Country = 2,
                            CreationDate = new DateTime(2023, 9, 2, 18, 21, 48, 343, DateTimeKind.Local).AddTicks(1483),
                            Email = "jane.doe@example.com",
                            EmailConfirmed = false,
                            FName = "Jane",
                            Governorate = 3,
                            LName = "Doe",
                            LockoutEnabled = false,
                            Password = "password123",
                            PhoneNumber = "987654321",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a089bc6b-5f28-42da-8b2f-b3afbcab8246",
                            TwoFactorEnabled = false,
                            UserName = "janedoe",
                            UserRole = 0
                        },
                        new
                        {
                            Id = "26a6d6a2-2fc2-4c75-907d-d4d9430b5e76",
                            AccessFailedCount = 0,
                            City = "London",
                            ConcurrencyStamp = "db4d3b44-ef90-4219-bdd6-17165a9a126f",
                            Country = 3,
                            CreationDate = new DateTime(2023, 9, 2, 18, 21, 48, 343, DateTimeKind.Local).AddTicks(1496),
                            Email = "michael.smith@example.com",
                            EmailConfirmed = false,
                            FName = "Michael",
                            Governorate = 4,
                            LName = "Smith",
                            LockoutEnabled = false,
                            Password = "password123",
                            PhoneNumber = "321456789",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a4dd6ad3-02b2-419e-b667-1e974b87de89",
                            TwoFactorEnabled = false,
                            UserName = "michaelsmith",
                            UserRole = 0
                        },
                        new
                        {
                            Id = "8c4fefdd-75a9-497f-91a8-e8eb537135c6",
                            AccessFailedCount = 0,
                            City = "Paris",
                            ConcurrencyStamp = "5bad64f0-db22-4594-bd62-54707caf8b27",
                            Country = 4,
                            CreationDate = new DateTime(2023, 9, 2, 18, 21, 48, 343, DateTimeKind.Local).AddTicks(1514),
                            Email = "david.williams@example.com",
                            EmailConfirmed = false,
                            FName = "David",
                            Governorate = 5,
                            LName = "Williams",
                            LockoutEnabled = false,
                            Password = "password123",
                            PhoneNumber = "765432109",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "88be0434-cb13-4ded-a475-1cc50d9684bd",
                            TwoFactorEnabled = false,
                            UserName = "davidwilliams",
                            UserRole = 0
                        },
                        new
                        {
                            Id = "8d230bcb-716a-46db-b1ab-0fba86fac50b",
                            AccessFailedCount = 0,
                            City = "Rome",
                            ConcurrencyStamp = "c8323fbb-c5a4-4158-9f28-c03e1c0527d4",
                            Country = 5,
                            CreationDate = new DateTime(2023, 9, 2, 18, 21, 48, 343, DateTimeKind.Local).AddTicks(1541),
                            Email = "elizabeth.brown@example.com",
                            EmailConfirmed = false,
                            FName = "Elizabeth",
                            Governorate = 6,
                            LName = "Brown",
                            LockoutEnabled = false,
                            Password = "password123",
                            PhoneNumber = "543210987",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0b672e65-c449-4e4e-9d6c-c4c0b089ff20",
                            TwoFactorEnabled = false,
                            UserName = "elizabethbrown",
                            UserRole = 1
                        },
                        new
                        {
                            Id = "ec41f813-d16c-482c-9fd9-f70b8b149486",
                            AccessFailedCount = 0,
                            City = "Tokyo",
                            ConcurrencyStamp = "545a1d5e-8882-408d-b98e-17c6e41291a9",
                            Country = 6,
                            CreationDate = new DateTime(2023, 9, 2, 18, 21, 48, 343, DateTimeKind.Local).AddTicks(1559),
                            Email = "thomas.anderson@example.com",
                            EmailConfirmed = false,
                            FName = "Thomas",
                            Governorate = 7,
                            LName = "Anderson",
                            LockoutEnabled = false,
                            Password = "password123",
                            PhoneNumber = "987654321",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "36c328c4-b532-44e4-8284-783847cee2d6",
                            TwoFactorEnabled = false,
                            UserName = "thomasanderson",
                            UserRole = 0
                        });
                });

            modelBuilder.Entity("Airbnb.DAL.UserReserveProperty", b =>
                {
                    b.Property<string>("PropertyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PropertyId", "CheckInDate");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Airbnb.DAL.UserReviewProperty", b =>
                {
                    b.Property<string>("PropertyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.HasKey("PropertyId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Airbnb.DAL.Images", b =>
                {
                    b.HasOne("Airbnb.DAL.Amenity", "Amenity")
                        .WithOne("Img")
                        .HasForeignKey("Airbnb.DAL.Images", "AmenityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Airbnb.DAL.Property", "Property")
                        .WithMany("Imgs")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Airbnb.DAL.Rules", "Rule")
                        .WithOne("Img")
                        .HasForeignKey("Airbnb.DAL.Images", "RuleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Airbnb.DAL.User", "User")
                        .WithOne("Img")
                        .HasForeignKey("Airbnb.DAL.Images", "UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Amenity");

                    b.Navigation("Property");

                    b.Navigation("Rule");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Airbnb.DAL.Property", b =>
                {
                    b.HasOne("Airbnb.DAL.User", "User")
                        .WithMany("Properties")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Airbnb.DAL.PropertyAmenity", b =>
                {
                    b.HasOne("Airbnb.DAL.Amenity", "Amenity")
                        .WithMany("PropertyAmenities")
                        .HasForeignKey("AmenityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.DAL.Property", "Property")
                        .WithMany("PropertyAmenities")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amenity");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Airbnb.DAL.PropertyRule", b =>
                {
                    b.HasOne("Airbnb.DAL.Property", "Property")
                        .WithMany("PropertyRules")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.DAL.Rules", "Rule")
                        .WithMany("PropertyRules")
                        .HasForeignKey("RuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");

                    b.Navigation("Rule");
                });

            modelBuilder.Entity("Airbnb.DAL.UserReserveProperty", b =>
                {
                    b.HasOne("Airbnb.DAL.Property", "Property")
                        .WithMany("Reservations")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Airbnb.DAL.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Airbnb.DAL.UserReviewProperty", b =>
                {
                    b.HasOne("Airbnb.DAL.Property", "Property")
                        .WithMany("Reviews")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.DAL.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Property");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Airbnb.DAL.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Airbnb.DAL.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airbnb.DAL.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Airbnb.DAL.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airbnb.DAL.Amenity", b =>
                {
                    b.Navigation("Img");

                    b.Navigation("PropertyAmenities");
                });

            modelBuilder.Entity("Airbnb.DAL.Property", b =>
                {
                    b.Navigation("Imgs");

                    b.Navigation("PropertyAmenities");

                    b.Navigation("PropertyRules");

                    b.Navigation("Reservations");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Airbnb.DAL.Rules", b =>
                {
                    b.Navigation("Img");

                    b.Navigation("PropertyRules");
                });

            modelBuilder.Entity("Airbnb.DAL.User", b =>
                {
                    b.Navigation("Img");

                    b.Navigation("Properties");

                    b.Navigation("Reservations");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
