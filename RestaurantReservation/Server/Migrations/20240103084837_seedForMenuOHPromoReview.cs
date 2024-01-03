using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantReservation.Server.Migrations
{
    /// <inheritdoc />
    public partial class seedForMenuOHPromoReview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e0419f3-4b16-4823-a8b6-44509e34abc4", "AQAAAAIAAYagAAAAEHa6wC3BDPKeL50XpeWk4TsB1yO1OtjXA/JT9/O7pqpkAJ1F4K2LSSpyowTYsdL4KA==", "1451baad-84e2-46cc-ad82-f080bdb6ba42" });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "AllergyContents", "Description", "DishName", "ImagePath", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, null, null, "HotPot", "images/haidilaoMenu.jpg", null, 1 },
                    { 2, null, null, "HotPot", "images/sichuandouhuaMenu.jpg", null, 2 },
                    { 3, null, null, "HotPot", "images/beautyinthepotMenu.jpg", null, 3 },
                    { 4, null, null, "HotPot", "images/shabusaiMenu.jpg", null, 4 },
                    { 5, null, null, "HotPot", "images/cityhotpotMenu.jpg", null, 5 }
                });

            migrationBuilder.InsertData(
                table: "OperatingHours",
                columns: new[] { "Id", "ClosingTime", "Day", "OpeningTime", "RestaurantId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Monday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Friday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Monday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Friday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Monday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Friday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Monday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Friday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Monday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 30, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 32, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 33, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Friday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 34, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 35, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfExpiry",
                value: new DateTime(2025, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfExpiry",
                value: new DateTime(2025, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(3117));

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "Description", "Discount", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, "New year discount!", 10.0, new DateTime(2024, 2, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(7618), "NewYear", new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(7617) },
                    { 2, "Chinese New Year discount!", 10.0, new DateTime(2024, 3, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(7628), "ChineseNewYear", new DateTime(2024, 2, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(7627) },
                    { 3, "Valentine's discount!", 10.0, new DateTime(2024, 4, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(7630), "Valentine", new DateTime(2024, 3, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(7629) }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 16, 48, 37, 235, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 16, 48, 37, 235, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 16, 48, 37, 235, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 16, 48, 37, 235, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CustomerId", "DateTime", "Description", "Rating", "RestaurantId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(8304), "description", 4, 1 },
                    { 2, null, new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(8312), "description", 4, 2 },
                    { 3, null, new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(8316), "description", 4, 3 },
                    { 4, null, new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(8318), "description", 4, 4 },
                    { 5, null, new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(8323), "description", 4, 5 }
                });

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(2479), new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(2491), new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(2487) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9680879-0a1b-41c8-9eeb-471d825b6771", "AQAAAAIAAYagAAAAEHPFewSi5zMNrg3pnfgqbxx96Vte96pRKjVRpVSttR0kOjVGE1zmlxTF+9favJ2rSg==", "31147f78-ad67-4f0b-bbdb-965009e04f13" });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfExpiry",
                value: new DateTime(2025, 1, 1, 16, 59, 28, 529, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfExpiry",
                value: new DateTime(2025, 1, 1, 16, 59, 28, 529, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 1, 16, 59, 28, 480, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 1, 16, 59, 28, 480, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 1, 16, 59, 28, 480, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 1, 16, 59, 28, 480, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 1, 16, 59, 28, 529, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 1, 16, 59, 28, 529, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 1, 1, 16, 59, 28, 529, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 1, 1, 16, 59, 28, 529, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 1, 1, 16, 59, 28, 529, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 59, 28, 529, DateTimeKind.Local).AddTicks(8698), new DateTime(2024, 1, 1, 16, 59, 28, 529, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 59, 28, 529, DateTimeKind.Local).AddTicks(8703), new DateTime(2024, 1, 1, 16, 59, 28, 529, DateTimeKind.Local).AddTicks(8703) });
        }
    }
}
