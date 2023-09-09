using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Airbnb.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false),
                    Governorate = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PropType = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false),
                    Governorate = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumOfPeople = table.Column<int>(type: "int", nullable: false),
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PropertyId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AmenityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Amenities_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Images_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Images_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Images_Rules_RuleId",
                        column: x => x.RuleId,
                        principalTable: "Rules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyAmenities",
                columns: table => new
                {
                    PropertyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AmenityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyAmenities", x => new { x.PropertyId, x.AmenityId });
                    table.ForeignKey(
                        name: "FK_PropertyAmenities_Amenities_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyAmenities_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyRules",
                columns: table => new
                {
                    RuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyRules", x => new { x.PropertyId, x.RuleId });
                    table.ForeignKey(
                        name: "FK_PropertyRules_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyRules_Rules_RuleId",
                        column: x => x.RuleId,
                        principalTable: "Rules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PropertyId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PropertyId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => new { x.PropertyId, x.UserId, x.Id });
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "Name", "Picture" },
                values: new object[,]
                {
                    { new Guid("4d74fe6e-a922-4d3c-9576-eee68a338b1e"), " Conditioner ", "2.jpg" },
                    { new Guid("62f6cb62-ab84-4b1e-a87d-d6b64d57c315"), " wi-fi ", "1.jpg" },
                    { new Guid("6b35635e-8d4e-4f6a-aca7-3f251b7d1e85"), " Iron ", "3.jpg" },
                    { new Guid("cf74c420-76f1-4290-89d9-14345074ec71"), " washing machine", "5.jpg" },
                    { new Guid("d455e249-7377-476a-bea2-55d1b289cdbe"), " Swimming Pool ", "4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Country", "CreationDate", "Email", "EmailConfirmed", "FName", "Governorate", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserRole" },
                values: new object[,]
                {
                    { "13c641c9-8e41-480f-85d8-d0d2af2d3ba7", 0, "Rome", "78671400-1253-4060-88c8-fa0fc93cc4c4", 5, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(961), "elizabeth.brown@example.com", false, "Elizabeth", 6, "Brown", false, null, null, null, "password123", null, "543210987", false, "e9755292-a124-4549-8958-404c292c9f19", false, "elizabethbrown", 1 },
                    { "2834c442-fde0-44c3-aa20-97b6bf23d36c", 0, "New York", "47862d5c-5c86-4ff9-959a-5b7ebee612b2", 1, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(859), "john.doe@example.com", false, "John", 2, "Doe", false, null, null, null, "password123", null, "123456789", false, "c1fa3888-e043-48ad-b69f-9eb098ed45f9", false, "johndoe", 0 },
                    { "98edc880-f3c2-42b0-a944-69aa52e9b575", 0, "Boston", "a52df465-d394-460f-8fab-37b636216c86", 6, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(988), "Jasmine.anderson@example.com", false, "Jasmin", 2, "Anderson", false, null, null, null, "password123", null, "987654321", false, "ee1e7f71-93e9-404c-b7b5-2d3f23d200db", false, "jasmineanderson", 0 },
                    { "a0dc6ae0-c640-40c4-aaf6-cdee63309590", 0, "London", "7cb59212-ea09-491c-b23a-965d3fca7c4f", 3, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(887), "michael.smith@example.com", false, "Michael", 4, "Smith", false, null, null, null, "password123", null, "321456789", false, "9736742c-def7-4891-bc52-2ae046de4f3e", false, "michaelsmith", 0 },
                    { "b54f9418-6573-479e-ae00-3fb9035222af", 0, "Los Angeles", "331a8bd1-5eda-4bde-96c0-0319c0e5ab1e", 2, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(873), "jane.doe@example.com", false, "Jane", 3, "Doe", false, null, null, null, "password123", null, "987654321", false, "d1079093-a376-4ede-82be-4ce863acf5bf", false, "janedoe", 0 },
                    { "b9a876a4-346e-4a9f-a671-14bd99e8c910", 0, "Texas", "77ab6001-bfd3-4b8e-837e-29cf487d0430", 2, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(1000), "sara.zuckerberg@example.com", false, "Sara", 7, "zukerberg", false, null, null, null, "password143", null, "987654321", false, "fa2fd44c-02af-4c22-b600-519e065470ea", false, "sara.zuckerberg", 0 },
                    { "ce1b8acf-75ec-4cca-961e-37ef153b7fee", 0, "Paris", "3b9eadd6-b72b-46ae-bf88-20905791ee0c", 4, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(900), "david.williams@example.com", false, "David", 5, "Williams", false, null, null, null, "password123", null, "765432109", false, "7c361641-f309-4228-b38b-2dfc0723aa09", false, "davidwilliams", 0 },
                    { "dbccdfa1-c95f-4ef4-a317-279f4495c657", 0, "Tokyo", "08815831-5d16-4130-ac67-6f478bebef23", 6, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(974), "thomas.anderson@example.com", false, "Thomas", 7, "Anderson", false, null, null, null, "password123", null, "987654321", false, "4159c286-bc8b-456d-9891-01f2496836a7", false, "thomasanderson", 0 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "AmenityId", "PropertyId", "RuleId", "URL", "UserId" },
                values: new object[,]
                {
                    { new Guid("1bd0a899-f0c0-42e8-9aba-ba28cb381f75"), null, null, null, "3.jpg", null },
                    { new Guid("61e47d7b-de60-4cf9-818e-073ecca73fb0"), null, null, null, "5.jpg", null },
                    { new Guid("7d150ab7-0c3e-4f42-8dda-7f9b27c3b292"), null, null, null, "6.jpg", null },
                    { new Guid("9b2a3642-5fe5-4735-a60a-caa77c3e66f2"), null, null, null, "4.jpg", null },
                    { new Guid("b2cba42d-0d6e-427e-a316-99cf2e502388"), null, null, null, "1.jpg", null },
                    { new Guid("d705d907-9693-443a-acf4-40aa5d6bb5cc"), null, null, null, "2.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "Rules",
                columns: new[] { "Id", "Name", "Picture" },
                values: new object[,]
                {
                    { new Guid("13b307e9-af15-4d61-92fb-8838fadc0c1a"), "No Smoking", "smoking.jpg" },
                    { new Guid("50364592-3d72-4f08-8827-a37186cf1aaf"), "No Smoking", "smoking.jpg" },
                    { new Guid("d42acf89-275b-4684-8a08-9735dc4c6087"), "No Smoking", "smoking.jpg" },
                    { new Guid("d7034dfe-ab78-47ec-9625-151678b4367c"), "No Smoking", "smoking.jpg" },
                    { new Guid("e54d3ed7-6e2f-4faa-b52c-f22d36d67535"), "No Smoking", "smoking.jpg" },
                    { new Guid("e5fd3e4a-51e3-4f70-b613-08e2ec927bbd"), "No Smoking", "smoking.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "City", "Country", "CreationDate", "Description", "Governorate", "NumOfPeople", "PricePerNight", "PropType", "UserID" },
                values: new object[,]
                {
                    { "160b1ba2-fbe9-4126-9663-173e25c4f4a1", "Paris", 4, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(1043), "Cozy studio apartment in the city center", 5, 1, 50m, 4, "ce1b8acf-75ec-4cca-961e-37ef153b7fee" },
                    { "1822f457-a2e3-40c1-b3ce-3b14e2f01893", "Los Angeles", 2, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(1030), "Luxurious villa with a pool and garden", 3, 6, 200m, 1, "b54f9418-6573-479e-ae00-3fb9035222af" },
                    { "6d2fa267-40de-4641-8b26-94ec2fd4130a", "New York", 1, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(1016), "Beautiful apartment in the heart of the city", 2, 4, 100m, 0, "2834c442-fde0-44c3-aa20-97b6bf23d36c" },
                    { "bf0368e6-ff52-4c04-9e2e-fc3940cf99f8", "Texas", 6, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(1067), "Luxurious penthouse with a view", 7, 6, 200m, 3, "98edc880-f3c2-42b0-a944-69aa52e9b575" },
                    { "dcf81030-7840-4417-9d57-275bc9009f36", "Tokyo", 6, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(1060), "Luxurious penthouse with a view", 7, 6, 200m, 3, "dbccdfa1-c95f-4ef4-a317-279f4495c657" },
                    { "f8f93b3b-0fb9-46ee-bc87-2498a9b4e251", "Rome", 5, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(1050), "Wooden cabin in the woods", 6, 4, 100m, 2, "13c641c9-8e41-480f-85d8-d0d2af2d3ba7" },
                    { "fa636394-1176-4498-ba5b-42c85781fdf7", "London", 3, new DateTime(2023, 9, 9, 12, 58, 9, 233, DateTimeKind.Local).AddTicks(1037), "Cozy cottage by the beach", 4, 2, 150m, 2, "a0dc6ae0-c640-40c4-aaf6-cdee63309590" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "PropertyId", "UserId" },
                values: new object[,]
                {
                    { new Guid("58e55a68-4a95-4551-808f-c780b2e86fa9"), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "bf0368e6-ff52-4c04-9e2e-fc3940cf99f8", "a0dc6ae0-c640-40c4-aaf6-cdee63309590" },
                    { new Guid("96be2b5b-9630-4468-98bf-7f862ee0b401"), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "1822f457-a2e3-40c1-b3ce-3b14e2f01893", "13c641c9-8e41-480f-85d8-d0d2af2d3ba7" },
                    { new Guid("a47298bc-7667-4252-8ade-3a70e80bc7ac"), new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "dcf81030-7840-4417-9d57-275bc9009f36", "b54f9418-6573-479e-ae00-3fb9035222af" },
                    { new Guid("bfb4b4ba-3d7f-4654-94f0-994966722e03"), new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "160b1ba2-fbe9-4126-9663-173e25c4f4a1", "dbccdfa1-c95f-4ef4-a317-279f4495c657" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "PropertyId", "UserId", "Rating" },
                values: new object[,]
                {
                    { new Guid("8ad821b3-0eae-4ed7-bd52-ba5552f52852"), "160b1ba2-fbe9-4126-9663-173e25c4f4a1", "13c641c9-8e41-480f-85d8-d0d2af2d3ba7", 4.5f },
                    { new Guid("51c1cb6a-c458-4028-b52e-df31e17636d2"), "1822f457-a2e3-40c1-b3ce-3b14e2f01893", "a0dc6ae0-c640-40c4-aaf6-cdee63309590", 2.3f },
                    { new Guid("83918fed-352d-4c67-8f44-b0bea1d725c0"), "dcf81030-7840-4417-9d57-275bc9009f36", "dbccdfa1-c95f-4ef4-a317-279f4495c657", 4.5f },
                    { new Guid("375f5ff3-3b27-44fd-876f-a1953f7bdc03"), "f8f93b3b-0fb9-46ee-bc87-2498a9b4e251", "ce1b8acf-75ec-4cca-961e-37ef153b7fee", 4.5f },
                    { new Guid("4435fd79-ceec-40a5-9a4d-bd1ac37a990e"), "fa636394-1176-4498-ba5b-42c85781fdf7", "b54f9418-6573-479e-ae00-3fb9035222af", 1.2f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Images_AmenityId",
                table: "Images",
                column: "AmenityId",
                unique: true,
                filter: "[AmenityId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PropertyId",
                table: "Images",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_RuleId",
                table: "Images",
                column: "RuleId",
                unique: true,
                filter: "[RuleId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Images_UserId",
                table: "Images",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_UserID",
                table: "Properties",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyAmenities_AmenityId",
                table: "PropertyAmenities",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyRules_RuleId",
                table: "PropertyRules",
                column: "RuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PropertyId",
                table: "Reservations",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "PropertyAmenities");

            migrationBuilder.DropTable(
                name: "PropertyRules");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
