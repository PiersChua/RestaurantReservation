using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantReservation.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedForFavouirteSeatingCapSubscriptionDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d215f5a1-f7f1-40d4-a29f-971a41910b50", "AQAAAAIAAYagAAAAEGR1Z5H8GoHskvKrbgRqTP9BQxn2dSxyVk13nNYpVlLonXjC3BpdttFbwsRsjwkG/Q==", "5edf10ad-66ac-403a-9408-021f869d50b4" });

            migrationBuilder.InsertData(
                table: "Favourites",
                columns: new[] { "Id", "CustomerId", "Name", "RestaurantId" },
                values: new object[,]
                {
                    { 1, null, "Hai Di Lao", 1 },
                    { 2, null, "Hai Di Lao", 2 },
                    { 3, null, "Hai Di Lao", 3 },
                    { 4, null, "Hai Di Lao", 5 }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 11, 41, 25, 197, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 11, 41, 25, 197, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 11, 41, 25, 197, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 11, 41, 25, 197, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.InsertData(
                table: "SeatingCapacities",
                columns: new[] { "Id", "Capacity", "Date", "RestaurantId" },
                values: new object[,]
                {
                    { 1, 15, new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(4826), 1 },
                    { 2, 15, new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(4839), 2 },
                    { 3, 15, new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(4840), 3 },
                    { 4, 15, new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(4841), 4 },
                    { 5, 15, new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(4843), 5 }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "EndDate", "PlatformFee", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(5050), 10.0, new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(5050) },
                    { 2, new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(5052), 10.0, new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(5052) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfd18a2e-6a6e-4fdf-8f7f-406d84d67f76", "AQAAAAIAAYagAAAAEPdsZ4t4o9eXmcXCIoJnkTxq3MEZZiFtXNP1HO+NBzKxGR9sQq7yeG7WcwtkIq2gJw==", "69696817-e30c-44c3-9dda-154bae1b91d5" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 11, 35, 18, 473, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 11, 35, 18, 473, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 11, 35, 18, 473, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 12, 31, 11, 35, 18, 473, DateTimeKind.Local).AddTicks(9468));
        }
    }
}
