using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantReservation.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeededReservationData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "706fdd26-f740-4d69-9d6c-6bd575da1faf", "AQAAAAIAAYagAAAAEMlHPl/svcTZDPGh21Xg3Bm5amMEp9Iaovo8V6Zo59Nq2GGS9FitkUgDRX2YAD+Z8g==", "59d0b590-fbf8-4f38-a531-443802f08b51" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "DateTime", "Guest", "PromotionId", "Request", "ReservationStatusId", "RestaurantId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 12, 30, 10, 32, 55, 487, DateTimeKind.Local).AddTicks(9281), 2, null, "None", null, 1 },
                    { 2, null, new DateTime(2023, 12, 30, 10, 32, 55, 487, DateTimeKind.Local).AddTicks(9290), 3, null, "None", null, 2 },
                    { 3, null, new DateTime(2023, 12, 30, 10, 32, 55, 487, DateTimeKind.Local).AddTicks(9291), 4, null, "None", null, 3 },
                    { 4, null, new DateTime(2023, 12, 30, 10, 32, 55, 487, DateTimeKind.Local).AddTicks(9293), 2, null, "None", null, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39d63585-d65c-4f9d-9e55-33649455a093", "AQAAAAIAAYagAAAAEJkCJlwRMXdUYFR5Twl+TMFb69JOcbcTTi3afX4FtTefXQUVvmaNVmxbrWf5Bd90/Q==", "f060efc7-acf0-438b-a92a-81b1f7a5d25b" });
        }
    }
}
