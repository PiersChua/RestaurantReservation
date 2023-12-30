using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedLazyLoadingOfReservationsFromRestaurants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "706fdd26-f740-4d69-9d6c-6bd575da1faf", "AQAAAAIAAYagAAAAEMlHPl/svcTZDPGh21Xg3Bm5amMEp9Iaovo8V6Zo59Nq2GGS9FitkUgDRX2YAD+Z8g==", "59d0b590-fbf8-4f38-a531-443802f08b51" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 12, 30, 10, 32, 55, 487, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 12, 30, 10, 32, 55, 487, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 12, 30, 10, 32, 55, 487, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 12, 30, 10, 32, 55, 487, DateTimeKind.Local).AddTicks(9293));
        }
    }
}
