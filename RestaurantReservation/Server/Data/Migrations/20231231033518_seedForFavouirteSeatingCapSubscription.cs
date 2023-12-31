using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedForFavouirteSeatingCapSubscription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d165d772-2be1-4e46-bb1d-1694c7e5ce31", "AQAAAAIAAYagAAAAEFK8nDnNRyqCiUgqwsU4A6KxLn7zrPn50eRSxn1t07YrRZnkoP6sUalr1YQk2oELnw==", "cde75d96-9c36-490c-9e7d-ef9d0412e78a" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 12, 30, 20, 39, 1, 711, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 12, 30, 20, 39, 1, 711, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 12, 30, 20, 39, 1, 711, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 12, 30, 20, 39, 1, 711, DateTimeKind.Local).AddTicks(3785));
        }
    }
}
