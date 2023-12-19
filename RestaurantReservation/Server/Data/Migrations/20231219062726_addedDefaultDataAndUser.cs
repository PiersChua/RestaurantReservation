using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantReservation.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Building", "Level", "PostalCode", "Street", "UnitNumber" },
                values: new object[,]
                {
                    { 1, "Century Square", 2, 529509, "2 Tampines Central 5", "#02-22" },
                    { 2, "Parkroyal", 1, 199591, "7500 Beach Rd", null },
                    { 3, "VivoCity", 3, 98585, "1 HarbourFront Walk", "#03-08A" },
                    { 4, "Tampines 1", 2, 529536, " 10 Tampines Central 1", "#02-04" },
                    { 5, "One Raffles Place", 4, 48616, "1 Raffles Place", "#04-26/27/28" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69d41a28-6af8-47fe-aa0c-7785bd7233f5", null, "Staff", "STAFF" },
                    { "f0926ab0-0927-48bb-8f5a-92a5d1acbade", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb", 0, "0a2b4cdf-f654-49e5-8bcd-0ac46eb52815", "admin@localhost.com", false, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHXAsybbS+uloRLl8kVYaatt9M5zsavTPZYuyyk6uI3sGcha5H2jBW3hCvo705RBBg==", null, false, "4bc18dd3-88e0-4b26-a60f-45ffe0e3c6a1", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "69d41a28-6af8-47fe-aa0c-7785bd7233f5", "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "AddressId", "Cuisine", "Email", "ImagePath", "Name", "PhoneNumber", "RestaurantOwnerId", "SubscriptionId" },
                values: new object[,]
                {
                    { 1, 1, "Chinese", null, "images/haidilao.jpg", "Hai Di Lao", 67804201, null, null },
                    { 2, 2, "Chinese", null, "images/sichuandouhua.jpg", "Si Chuan Dou Hua", 67804201, null, null },
                    { 3, 3, "Chinese", null, "images/beautyinthepot.jpg", "Beauty In The Pot", 67804201, null, null },
                    { 4, 4, "Chinese", null, "images/shabusai.jpg", "Shabu Sai", 67804201, null, null },
                    { 5, 5, "Chinese", null, "images/cityhotpot.jpg", "City Hotpot", 67804201, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0926ab0-0927-48bb-8f5a-92a5d1acbade");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69d41a28-6af8-47fe-aa0c-7785bd7233f5", "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb" });

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69d41a28-6af8-47fe-aa0c-7785bd7233f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb");
        }
    }
}
