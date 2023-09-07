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
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("07ac4e91-a760-4de0-ac70-df15497452da"));

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("368a7e79-be12-44a3-ab06-6a144b2ab21b"));

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("536c3c7d-2241-46ab-8020-83e9b835cbc5"));

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("8b52d712-8550-4505-a36d-2896c58eef1d"));

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("d37fda98-084d-4dfa-ad31-6b94048fd70f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da364373-daaf-4c17-be28-d51edf5b3dc1");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0c75a38e-fc5e-41fa-809e-13c7c85c3db2"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("35d30429-a423-4e10-a8e9-158301d6d35c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8aea011a-d621-419f-aa97-3cc6d1d915f8"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("aa3b9d96-1ec1-4550-97c7-0ecf1fb9cd90"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b2f7b04c-2c66-4f6b-ae94-cee567214ec9"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d41de92c-9643-4317-acec-ab2c3160c05d"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "a9c93179-3bd7-4445-8b00-f7eac80258e4");

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("0be13561-8de8-4a05-a9bf-b17b0286c603"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("38e74717-612b-4f02-baed-35792f8d78f0"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("a765d8d9-a4ad-4487-9885-9e440655cbef"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cc039bf3-e57d-4ab8-9f99-1d12519abad5"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "PropertyId", "UserId" },
                keyValues: new object[] { "3550e988-02d6-49b1-a277-eb946a19b7cb", "0461d5f0-e1fd-4d41-9c9a-d2d8f7959bc9" });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "PropertyId", "UserId" },
                keyValues: new object[] { "59e178be-586f-4239-befd-94430550497b", "44a61808-2a1c-4762-b9ef-aeff11945916" });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "PropertyId", "UserId" },
                keyValues: new object[] { "bdd07057-f57f-484d-9b1f-8630788ec67a", "dd5109a9-0826-4b87-8e71-b5bd90f421e9" });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "PropertyId", "UserId" },
                keyValues: new object[] { "dd9e7e06-344d-4359-8a01-205f8927d1d7", "f1941b39-7835-4c99-a68b-920703789333" });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "PropertyId", "UserId" },
                keyValues: new object[] { "fb4c52fc-78bd-4336-9f19-1297d71f3b36", "71f6024d-f70b-4b04-9f50-3ac00d50b10b" });

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: new Guid("713c5270-6c26-43b1-ae93-9f67ba1ea6f4"));

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: new Guid("7c5ee365-f5ac-47ed-ab1e-3f41b1d27938"));

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: new Guid("8987a353-174b-4f5d-a22b-b534c6b33ba7"));

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: new Guid("b15d8b4d-87b0-4ecf-9a41-d27e5fb885a9"));

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: new Guid("e06d6d2a-8837-4c32-bfc6-ebff362326af"));

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: new Guid("fdd1136a-6a95-49d3-9ab3-82a87c2b43f2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90217a1e-3741-4588-9d78-7c786a4f7059");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "0f5a9f01-674e-4d00-8930-9c7797e7bc4d");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "3550e988-02d6-49b1-a277-eb946a19b7cb");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "59e178be-586f-4239-befd-94430550497b");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "bdd07057-f57f-484d-9b1f-8630788ec67a");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "dd9e7e06-344d-4359-8a01-205f8927d1d7");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "fb4c52fc-78bd-4336-9f19-1297d71f3b36");

            //migrationBuilder.DeleteData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "0461d5f0-e1fd-4d41-9c9a-d2d8f7959bc9");

            //migrationBuilder.DeleteData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "44a61808-2a1c-4762-b9ef-aeff11945916");

            //migrationBuilder.DeleteData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "4f529348-2ce3-49b2-94fb-ec40a346adce");

            //migrationBuilder.DeleteData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "71f6024d-f70b-4b04-9f50-3ac00d50b10b");

            //migrationBuilder.DeleteData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "dd5109a9-0826-4b87-8e71-b5bd90f421e9");

            //migrationBuilder.DeleteData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "f1941b39-7835-4c99-a68b-920703789333");

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "Name", "Picture" },
                values: new object[,]
                {
                    { new Guid("55cf6efe-a8fe-4e55-9eb9-74dabfc5be80"), " Iron ", "3.jpg" },
                    { new Guid("603ebd6a-a550-473c-811e-54386a452d0b"), " Conditioner ", "2.jpg" },
                    { new Guid("9e654961-c298-4cdf-b6d3-340471d57284"), " washing machine", "5.jpg" },
                    { new Guid("e48435a4-ae66-4c5e-942a-195ffa40f462"), " wi-fi ", "1.jpg" },
                    { new Guid("f4b99885-98e9-4811-ab36-2519943de44e"), " Swimming Pool ", "4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Country", "CreationDate", "Email", "EmailConfirmed", "FName", "Governorate", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserRole" },
                values: new object[,]
                {
                    { "74e47c84-feea-4e20-9096-a552092c6f09", 0, "New York", "3096ed45-925d-4d72-8abf-fc98c4e75686", 1, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8398), "john.doe@example.com", false, "John", 2, "Doe", false, null, null, null, "password123", null, "123456789", false, "e2aef09a-ffb0-4e33-9907-7048a976a201", false, "johndoe", 0 },
                    { "7924436b-7f5f-4850-bff3-0e82e9030db4", 0, "London", "783efc90-6dbb-4a9d-bbf4-2b2b35ad74f5", 3, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8444), "michael.smith@example.com", false, "Michael", 4, "Smith", false, null, null, null, "password123", null, "321456789", false, "1ad061ae-0629-4bd1-a2de-dd14dc51b4e0", false, "michaelsmith", 0 },
                    { "80e62e27-8144-4028-8fd8-b7889bcbd6fb", 0, "Tokyo", "d5b75740-1f3b-42ec-8d71-48368d84fd4f", 6, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8686), "thomas.anderson@example.com", false, "Thomas", 7, "Anderson", false, null, null, null, "password123", null, "987654321", false, "6020b8f2-7a2b-4f36-88e8-47fc37fc35ed", false, "thomasanderson", 0 },
                    { "8145ae5c-7bf5-415d-90f6-8f2149cf73bc", 0, "Los Angeles", "88cae276-4d57-46e0-857b-d3d7b1281f14", 2, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8430), "jane.doe@example.com", false, "Jane", 3, "Doe", false, null, null, null, "password123", null, "987654321", false, "8f13faee-ed59-4f09-9cc5-83f42184710c", false, "janedoe", 0 },
                    { "9050c9ce-a306-42af-8a7c-1d70599ecbb0", 0, "Boston", "17eb6f8d-4716-4793-9121-d2bb055e3fc4", 6, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8703), "Jasmine.anderson@example.com", false, "Jasmin", 2, "Anderson", false, null, null, null, "password123", null, "987654321", false, "9abe5166-f08c-4bf8-9609-42590981bafe", false, "jasmineanderson", 0 },
                    { "97b40974-0840-4ba4-9627-0f3819eccac5", 0, "Rome", "6f07a583-c5d2-4a9c-834d-d596c5593185", 5, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8656), "elizabeth.brown@example.com", false, "Elizabeth", 6, "Brown", false, null, null, null, "password123", null, "543210987", false, "a003463e-1566-4cc7-ab65-e3a64f0e6d03", false, "elizabethbrown", 1 },
                    { "a2261d27-1adb-4441-9c8d-c7b1d76b9351", 0, "Paris", "784bf452-2dec-4343-98e0-504b6f8e7c1c", 4, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8637), "david.williams@example.com", false, "David", 5, "Williams", false, null, null, null, "password123", null, "765432109", false, "59e54929-624b-4fdf-ba2f-47661a77721b", false, "davidwilliams", 0 },
                    { "eccf057b-0485-4380-8bdd-e02a4c64e2e7", 0, "Texas", "55e3b399-88ba-4b76-a952-c04d35d7c7f0", 2, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8727), "sara.zuckerberg@example.com", false, "Sara", 7, "zukerberg", false, null, null, null, "password143", null, "987654321", false, "85515acd-55bf-4527-965d-509b65ffe60d", false, "sara.zuckerberg", 0 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "AmenityId", "PropertyId", "RuleId", "URL", "UserId" },
                values: new object[,]
                {
                    { new Guid("3955bab6-2ede-4ab0-890b-8d248c5e8134"), null, null, null, "4.jpg", null },
                    { new Guid("416d9511-e0ce-48b2-8e66-619e8badbd26"), null, null, null, "5.jpg", null },
                    { new Guid("575d5dc6-5ffd-4b7c-ba11-2027246ad5bc"), null, null, null, "2.jpg", null },
                    { new Guid("65d6aeef-d876-4820-84d9-3dae3226f9e1"), null, null, null, "6.jpg", null },
                    { new Guid("772b0741-caf1-43c4-991a-0290416cf105"), null, null, null, "1.jpg", null },
                    { new Guid("bbb1441d-e19c-45c8-9b1a-c1031b04597b"), null, null, null, "3.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "Rules",
                columns: new[] { "Id", "Name", "Picture" },
                values: new object[,]
                {
                    { new Guid("5be138b1-85e8-4f08-a047-6c0ca60054d1"), "No Smoking", "smoking.jpg" },
                    { new Guid("6bba2c2d-d604-495b-b148-2a261effdbf6"), "No Smoking", "smoking.jpg" },
                    { new Guid("994d70ad-3b4d-43d7-8e5b-bb43b22c5c76"), "No Smoking", "smoking.jpg" },
                    { new Guid("b96e77e3-dcb6-4267-9c88-59fcdab1ebb9"), "No Smoking", "smoking.jpg" },
                    { new Guid("d4e5f95f-1c39-4e82-b38a-ff92998ee1f0"), "No Smoking", "smoking.jpg" },
                    { new Guid("dee7a757-c1b7-4893-90b3-524288cf583d"), "No Smoking", "smoking.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "City", "Country", "CreationDate", "Description", "Governorate", "NumOfPeople", "PricePerNight", "PropType", "UserID" },
                values: new object[,]
                {
                    { "23fab38d-3a87-4e17-9b5c-97b3e9d992e2", "Los Angeles", 2, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8865), "Luxurious villa with a pool and garden", 3, 6, 200m, 1, "8145ae5c-7bf5-415d-90f6-8f2149cf73bc" },
                    { "25999634-0518-4f3c-9c31-73e022174f13", "Texas", 6, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8939), "Luxurious penthouse with a view", 7, 6, 200m, 3, "9050c9ce-a306-42af-8a7c-1d70599ecbb0" },
                    { "8cbcaf61-9cd2-4884-abc3-8f60a74bca76", "London", 3, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8881), "Cozy cottage by the beach", 4, 2, 150m, 2, "7924436b-7f5f-4850-bff3-0e82e9030db4" },
                    { "8fe44c35-c24f-4d7a-977e-424318162729", "New York", 1, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8845), "Beautiful apartment in the heart of the city", 2, 4, 100m, 0, "74e47c84-feea-4e20-9096-a552092c6f09" },
                    { "afe5121f-ffa8-4298-a4c2-1c5cc8d7ee0c", "Paris", 4, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8893), "Cozy studio apartment in the city center", 5, 1, 50m, 4, "a2261d27-1adb-4441-9c8d-c7b1d76b9351" },
                    { "c130bc6c-b583-4995-89d1-c49a758bf189", "Rome", 5, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8910), "Wooden cabin in the woods", 6, 4, 100m, 2, "97b40974-0840-4ba4-9627-0f3819eccac5" },
                    { "de4f8c56-de71-40db-a34a-5df63a761abd", "Tokyo", 6, new DateTime(2023, 9, 7, 23, 34, 58, 463, DateTimeKind.Local).AddTicks(8925), "Luxurious penthouse with a view", 7, 6, 200m, 3, "80e62e27-8144-4028-8fd8-b7889bcbd6fb" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "PropertyId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00e33fe9-4201-4d89-ae0b-1db2e6c36652"), new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "de4f8c56-de71-40db-a34a-5df63a761abd", "8145ae5c-7bf5-415d-90f6-8f2149cf73bc" },
                    { new Guid("6b737101-d5c8-4d67-9ed5-290f6a991d2e"), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "23fab38d-3a87-4e17-9b5c-97b3e9d992e2", "97b40974-0840-4ba4-9627-0f3819eccac5" },
                    { new Guid("b57580ce-37ab-4e5a-9452-a3b6f151c4af"), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "25999634-0518-4f3c-9c31-73e022174f13", "7924436b-7f5f-4850-bff3-0e82e9030db4" },
                    { new Guid("c022398f-dbe6-4302-bf7c-ea9a5b6fa003"), new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "afe5121f-ffa8-4298-a4c2-1c5cc8d7ee0c", "80e62e27-8144-4028-8fd8-b7889bcbd6fb" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "PropertyId", "UserId", "Rating" },
                values: new object[,]
                {
                    { "23fab38d-3a87-4e17-9b5c-97b3e9d992e2", "7924436b-7f5f-4850-bff3-0e82e9030db4", 2.3f },
                    { "8cbcaf61-9cd2-4884-abc3-8f60a74bca76", "8145ae5c-7bf5-415d-90f6-8f2149cf73bc", 1.2f },
                    { "afe5121f-ffa8-4298-a4c2-1c5cc8d7ee0c", "97b40974-0840-4ba4-9627-0f3819eccac5", 4.5f },
                    { "c130bc6c-b583-4995-89d1-c49a758bf189", "a2261d27-1adb-4441-9c8d-c7b1d76b9351", 4.5f },
                    { "de4f8c56-de71-40db-a34a-5df63a761abd", "80e62e27-8144-4028-8fd8-b7889bcbd6fb", 4.5f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("55cf6efe-a8fe-4e55-9eb9-74dabfc5be80"));

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("603ebd6a-a550-473c-811e-54386a452d0b"));

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("9e654961-c298-4cdf-b6d3-340471d57284"));

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("e48435a4-ae66-4c5e-942a-195ffa40f462"));

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("f4b99885-98e9-4811-ab36-2519943de44e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eccf057b-0485-4380-8bdd-e02a4c64e2e7");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3955bab6-2ede-4ab0-890b-8d248c5e8134"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("416d9511-e0ce-48b2-8e66-619e8badbd26"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("575d5dc6-5ffd-4b7c-ba11-2027246ad5bc"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("65d6aeef-d876-4820-84d9-3dae3226f9e1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("772b0741-caf1-43c4-991a-0290416cf105"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("bbb1441d-e19c-45c8-9b1a-c1031b04597b"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "8fe44c35-c24f-4d7a-977e-424318162729");

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("00e33fe9-4201-4d89-ae0b-1db2e6c36652"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("6b737101-d5c8-4d67-9ed5-290f6a991d2e"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("b57580ce-37ab-4e5a-9452-a3b6f151c4af"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("c022398f-dbe6-4302-bf7c-ea9a5b6fa003"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "PropertyId", "UserId" },
                keyValues: new object[] { "23fab38d-3a87-4e17-9b5c-97b3e9d992e2", "7924436b-7f5f-4850-bff3-0e82e9030db4" });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "PropertyId", "UserId" },
                keyValues: new object[] { "8cbcaf61-9cd2-4884-abc3-8f60a74bca76", "8145ae5c-7bf5-415d-90f6-8f2149cf73bc" });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "PropertyId", "UserId" },
                keyValues: new object[] { "afe5121f-ffa8-4298-a4c2-1c5cc8d7ee0c", "97b40974-0840-4ba4-9627-0f3819eccac5" });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "PropertyId", "UserId" },
                keyValues: new object[] { "c130bc6c-b583-4995-89d1-c49a758bf189", "a2261d27-1adb-4441-9c8d-c7b1d76b9351" });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "PropertyId", "UserId" },
                keyValues: new object[] { "de4f8c56-de71-40db-a34a-5df63a761abd", "80e62e27-8144-4028-8fd8-b7889bcbd6fb" });

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: new Guid("5be138b1-85e8-4f08-a047-6c0ca60054d1"));

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: new Guid("6bba2c2d-d604-495b-b148-2a261effdbf6"));

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: new Guid("994d70ad-3b4d-43d7-8e5b-bb43b22c5c76"));

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: new Guid("b96e77e3-dcb6-4267-9c88-59fcdab1ebb9"));

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: new Guid("d4e5f95f-1c39-4e82-b38a-ff92998ee1f0"));

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: new Guid("dee7a757-c1b7-4893-90b3-524288cf583d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74e47c84-feea-4e20-9096-a552092c6f09");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "23fab38d-3a87-4e17-9b5c-97b3e9d992e2");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "25999634-0518-4f3c-9c31-73e022174f13");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "8cbcaf61-9cd2-4884-abc3-8f60a74bca76");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "afe5121f-ffa8-4298-a4c2-1c5cc8d7ee0c");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "c130bc6c-b583-4995-89d1-c49a758bf189");

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: "de4f8c56-de71-40db-a34a-5df63a761abd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7924436b-7f5f-4850-bff3-0e82e9030db4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80e62e27-8144-4028-8fd8-b7889bcbd6fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8145ae5c-7bf5-415d-90f6-8f2149cf73bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9050c9ce-a306-42af-8a7c-1d70599ecbb0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97b40974-0840-4ba4-9627-0f3819eccac5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2261d27-1adb-4441-9c8d-c7b1d76b9351");

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "Name", "Picture" },
                values: new object[,]
                {
                    { new Guid("07ac4e91-a760-4de0-ac70-df15497452da"), " Iron ", "3.jpg" },
                    { new Guid("368a7e79-be12-44a3-ab06-6a144b2ab21b"), " Swimming Pool ", "4.jpg" },
                    { new Guid("536c3c7d-2241-46ab-8020-83e9b835cbc5"), " Conditioner ", "2.jpg" },
                    { new Guid("8b52d712-8550-4505-a36d-2896c58eef1d"), " wi-fi ", "1.jpg" },
                    { new Guid("d37fda98-084d-4dfa-ad31-6b94048fd70f"), " washing machine", "5.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Country", "CreationDate", "Email", "EmailConfirmed", "FName", "Governorate", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserRole" },
                values: new object[,]
                {
                    { "0461d5f0-e1fd-4d41-9c9a-d2d8f7959bc9", 0, "Los Angeles", "3b9f800b-0b69-4dea-b7a9-69b8d1ad770d", 2, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(3967), "jane.doe@example.com", false, "Jane", 3, "Doe", false, null, null, null, "password123", null, "987654321", false, "9d87e714-f6f5-4353-a7d1-e6cf28885732", false, "janedoe", 0 },
                    { "44a61808-2a1c-4762-b9ef-aeff11945916", 0, "Paris", "b2cfb8fa-2859-4137-8845-d6ebd22aa00e", 4, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(4007), "david.williams@example.com", false, "David", 5, "Williams", false, null, null, null, "password123", null, "765432109", false, "6560a316-d2a5-48a1-a4f0-f828c1992b99", false, "davidwilliams", 0 },
                    { "4f529348-2ce3-49b2-94fb-ec40a346adce", 0, "Boston", "8481bf9a-79c5-4a51-8f0b-40cabf61a39e", 6, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(4069), "Jasmine.anderson@example.com", false, "Jasmin", 2, "Anderson", false, null, null, null, "password123", null, "987654321", false, "1c23bb4c-657e-428f-8c17-a814e547d8fa", false, "jasmineanderson", 0 },
                    { "71f6024d-f70b-4b04-9f50-3ac00d50b10b", 0, "London", "d24763fe-d0bd-420b-b9a0-39a7947ade0e", 3, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(3990), "michael.smith@example.com", false, "Michael", 4, "Smith", false, null, null, null, "password123", null, "321456789", false, "62091908-a154-42d0-bbd8-3ca707c9c8f3", false, "michaelsmith", 0 },
                    { "90217a1e-3741-4588-9d78-7c786a4f7059", 0, "New York", "fe9b6ace-d415-4b74-b0ee-2d899d14b09f", 1, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(3944), "john.doe@example.com", false, "John", 2, "Doe", false, null, null, null, "password123", null, "123456789", false, "4a18402b-2020-4d4c-9b67-02bb37e5729e", false, "johndoe", 0 },
                    { "da364373-daaf-4c17-be28-d51edf5b3dc1", 0, "Texas", "b496cec1-776f-4eba-aeb0-402f1b52cdbf", 2, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(4109), "sara.zuckerberg@example.com", false, "Sara", 7, "zukerberg", false, null, null, null, "password143", null, "987654321", false, "92cdf4e8-e0ed-4c55-bcac-876beef4ae36", false, "sara.zuckerberg", 0 },
                    { "dd5109a9-0826-4b87-8e71-b5bd90f421e9", 0, "Tokyo", "0f069cd1-6b64-4562-887b-0c9e3278377d", 6, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(4049), "thomas.anderson@example.com", false, "Thomas", 7, "Anderson", false, null, null, null, "password123", null, "987654321", false, "0486cd7e-68eb-415a-b2e7-6fb91a54d9f4", false, "thomasanderson", 0 },
                    { "f1941b39-7835-4c99-a68b-920703789333", 0, "Rome", "248407c9-0d76-487c-b42f-2c368728e67e", 5, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(4027), "elizabeth.brown@example.com", false, "Elizabeth", 6, "Brown", false, null, null, null, "password123", null, "543210987", false, "e3409a2b-01f7-445c-89c7-feb180e0c349", false, "elizabethbrown", 1 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "AmenityId", "PropertyId", "RuleId", "URL", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c75a38e-fc5e-41fa-809e-13c7c85c3db2"), null, null, null, "2.jpg", null },
                    { new Guid("35d30429-a423-4e10-a8e9-158301d6d35c"), null, null, null, "6.jpg", null },
                    { new Guid("8aea011a-d621-419f-aa97-3cc6d1d915f8"), null, null, null, "1.jpg", null },
                    { new Guid("aa3b9d96-1ec1-4550-97c7-0ecf1fb9cd90"), null, null, null, "4.jpg", null },
                    { new Guid("b2f7b04c-2c66-4f6b-ae94-cee567214ec9"), null, null, null, "5.jpg", null },
                    { new Guid("d41de92c-9643-4317-acec-ab2c3160c05d"), null, null, null, "3.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "Rules",
                columns: new[] { "Id", "Name", "Picture" },
                values: new object[,]
                {
                    { new Guid("713c5270-6c26-43b1-ae93-9f67ba1ea6f4"), "No Smoking", "smoking.jpg" },
                    { new Guid("7c5ee365-f5ac-47ed-ab1e-3f41b1d27938"), "No Smoking", "smoking.jpg" },
                    { new Guid("8987a353-174b-4f5d-a22b-b534c6b33ba7"), "No Smoking", "smoking.jpg" },
                    { new Guid("b15d8b4d-87b0-4ecf-9a41-d27e5fb885a9"), "No Smoking", "smoking.jpg" },
                    { new Guid("e06d6d2a-8837-4c32-bfc6-ebff362326af"), "No Smoking", "smoking.jpg" },
                    { new Guid("fdd1136a-6a95-49d3-9ab3-82a87c2b43f2"), "No Smoking", "smoking.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "City", "Country", "CreationDate", "Description", "Governorate", "NumOfPeople", "PricePerNight", "PropType", "UserID" },
                values: new object[,]
                {
                    { "0f5a9f01-674e-4d00-8930-9c7797e7bc4d", "Texas", 6, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(4277), "Luxurious penthouse with a view", 7, 6, 200m, 3, "4f529348-2ce3-49b2-94fb-ec40a346adce" },
                    { "3550e988-02d6-49b1-a277-eb946a19b7cb", "London", 3, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(4162), "Cozy cottage by the beach", 4, 2, 150m, 2, "71f6024d-f70b-4b04-9f50-3ac00d50b10b" },
                    { "59e178be-586f-4239-befd-94430550497b", "Rome", 5, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(4239), "Wooden cabin in the woods", 6, 4, 100m, 2, "f1941b39-7835-4c99-a68b-920703789333" },
                    { "a9c93179-3bd7-4445-8b00-f7eac80258e4", "New York", 1, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(4133), "Beautiful apartment in the heart of the city", 2, 4, 100m, 0, "90217a1e-3741-4588-9d78-7c786a4f7059" },
                    { "bdd07057-f57f-484d-9b1f-8630788ec67a", "Tokyo", 6, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(4254), "Luxurious penthouse with a view", 7, 6, 200m, 3, "dd5109a9-0826-4b87-8e71-b5bd90f421e9" },
                    { "dd9e7e06-344d-4359-8a01-205f8927d1d7", "Paris", 4, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(4224), "Cozy studio apartment in the city center", 5, 1, 50m, 4, "44a61808-2a1c-4762-b9ef-aeff11945916" },
                    { "fb4c52fc-78bd-4336-9f19-1297d71f3b36", "Los Angeles", 2, new DateTime(2023, 9, 7, 23, 24, 11, 721, DateTimeKind.Local).AddTicks(4151), "Luxurious villa with a pool and garden", 3, 6, 200m, 1, "0461d5f0-e1fd-4d41-9c9a-d2d8f7959bc9" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "PropertyId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0be13561-8de8-4a05-a9bf-b17b0286c603"), new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "bdd07057-f57f-484d-9b1f-8630788ec67a", "0461d5f0-e1fd-4d41-9c9a-d2d8f7959bc9" },
                    { new Guid("38e74717-612b-4f02-baed-35792f8d78f0"), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0f5a9f01-674e-4d00-8930-9c7797e7bc4d", "71f6024d-f70b-4b04-9f50-3ac00d50b10b" },
                    { new Guid("a765d8d9-a4ad-4487-9885-9e440655cbef"), new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "dd9e7e06-344d-4359-8a01-205f8927d1d7", "dd5109a9-0826-4b87-8e71-b5bd90f421e9" },
                    { new Guid("cc039bf3-e57d-4ab8-9f99-1d12519abad5"), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "fb4c52fc-78bd-4336-9f19-1297d71f3b36", "f1941b39-7835-4c99-a68b-920703789333" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "PropertyId", "UserId", "Rating" },
                values: new object[,]
                {
                    { "3550e988-02d6-49b1-a277-eb946a19b7cb", "0461d5f0-e1fd-4d41-9c9a-d2d8f7959bc9", 1.2f },
                    { "59e178be-586f-4239-befd-94430550497b", "44a61808-2a1c-4762-b9ef-aeff11945916", 4.5f },
                    { "bdd07057-f57f-484d-9b1f-8630788ec67a", "dd5109a9-0826-4b87-8e71-b5bd90f421e9", 4.5f },
                    { "dd9e7e06-344d-4359-8a01-205f8927d1d7", "f1941b39-7835-4c99-a68b-920703789333", 4.5f },
                    { "fb4c52fc-78bd-4336-9f19-1297d71f3b36", "71f6024d-f70b-4b04-9f50-3ac00d50b10b", 2.3f }
                });
        }
    }
}
