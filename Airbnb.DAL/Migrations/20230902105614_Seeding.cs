using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Airbnb.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "CreationDate", "Email", "FName", "Governorate", "LName", "Password", "PhoneNumber", "UserName", "UserRole" },
                values: new object[,]
                {
                    { new Guid("0d7cba71-a72f-4015-b80c-62769a622628"), "Rome", 5, new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7651), "elizabeth.brown@example.com", "Elizabeth", 6, "Brown", "password123", "543210987", "elizabethbrown", 1 },
                    { new Guid("2ddd6235-d265-4303-9add-65619bc0b1e6"), "Los Angeles", 2, new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7623), "jane.doe@example.com", "Jane", 3, "Doe", "password123", "987654321", "janedoe", 0 },
                    { new Guid("373ae1d0-046e-41aa-b473-7b258a91ea3d"), "Paris", 4, new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7647), "david.williams@example.com", "David", 5, "Williams", "password123", "765432109", "davidwilliams", 0 },
                    { new Guid("4201d29d-4239-43fb-a907-7c7ca0836c9f"), "New York", 1, new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7618), "john.doe@example.com", "John", 2, "Doe", "password123", "123456789", "johndoe", 0 },
                    { new Guid("5c2821d2-6e03-4fd1-b304-370303e2f0d5"), "London", 3, new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7643), "michael.smith@example.com", "Michael", 4, "Smith", "password123", "321456789", "michaelsmith", 0 },
                    { new Guid("eec1a108-9941-443c-a35d-c3d7d6076be9"), "Tokyo", 6, new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7657), "thomas.anderson@example.com", "Thomas", 7, "Anderson", "password123", "987654321", "thomasanderson", 0 }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "UserID", "City", "Country", "CreationDate", "Description", "Governorate", "Id", "NumOfPeople", "PricePerNight", "PropType" },
                values: new object[,]
                {
                    { new Guid("0d7cba71-a72f-4015-b80c-62769a622628"), "Rome", 5, new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7687), "Wooden cabin in the woods", 6, new Guid("ac9060ae-a827-4925-b232-96518a6487e4"), 4, 100m, 2 },
                    { new Guid("2ddd6235-d265-4303-9add-65619bc0b1e6"), "Los Angeles", 2, new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7673), "Luxurious villa with a pool and garden", 3, new Guid("bf6ec124-8d8e-4c7a-8131-95bf9b504f5b"), 6, 200m, 1 },
                    { new Guid("373ae1d0-046e-41aa-b473-7b258a91ea3d"), "Paris", 4, new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7681), "Cozy studio apartment in the city center", 5, new Guid("be04c98b-9a9a-45c3-b813-6c2f3caedd9d"), 1, 50m, 4 },
                    { new Guid("4201d29d-4239-43fb-a907-7c7ca0836c9f"), "New York", 1, new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7664), "Beautiful apartment in the heart of the city", 2, new Guid("7fccf48d-5601-4903-b608-d00b7d3449f2"), 4, 100m, 0 },
                    { new Guid("5c2821d2-6e03-4fd1-b304-370303e2f0d5"), "London", 3, new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7677), "Cozy cottage by the beach", 4, new Guid("3e494a77-31e9-4f56-b6e5-31bed13ebcd9"), 2, 150m, 2 },
                    { new Guid("eec1a108-9941-443c-a35d-c3d7d6076be9"), "Tokyo", 6, new DateTime(2023, 9, 2, 13, 56, 14, 516, DateTimeKind.Local).AddTicks(7692), "Luxurious penthouse with a view", 7, new Guid("a1fbd31d-dba1-4cb7-8f96-25c453a42bce"), 6, 200m, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "UserID",
                keyValue: new Guid("0d7cba71-a72f-4015-b80c-62769a622628"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "UserID",
                keyValue: new Guid("2ddd6235-d265-4303-9add-65619bc0b1e6"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "UserID",
                keyValue: new Guid("373ae1d0-046e-41aa-b473-7b258a91ea3d"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "UserID",
                keyValue: new Guid("4201d29d-4239-43fb-a907-7c7ca0836c9f"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "UserID",
                keyValue: new Guid("5c2821d2-6e03-4fd1-b304-370303e2f0d5"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "UserID",
                keyValue: new Guid("eec1a108-9941-443c-a35d-c3d7d6076be9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d7cba71-a72f-4015-b80c-62769a622628"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ddd6235-d265-4303-9add-65619bc0b1e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("373ae1d0-046e-41aa-b473-7b258a91ea3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4201d29d-4239-43fb-a907-7c7ca0836c9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5c2821d2-6e03-4fd1-b304-370303e2f0d5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eec1a108-9941-443c-a35d-c3d7d6076be9"));
        }
    }
}
