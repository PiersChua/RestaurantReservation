using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantReservation.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedForResStatusPaymentResApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db4ddf6c-8f66-4ecc-92c7-a8f2dd2a5289", "AQAAAAIAAYagAAAAEFQq9hUCHGxGMDiTgXDaBr4JKWyhRoeuUSp63Dsq8Pyh+LnKi3E9yc66O6EroIEh1g==", "ef865a2e-3bf2-495e-8bd9-068de42af6e8" });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CVV", "CardNumber", "CustomerId", "DateOfExpiry" },
                values: new object[,]
                {
                    { 1, 123, 1, null, new DateTime(2024, 12, 31, 12, 14, 41, 216, DateTimeKind.Local).AddTicks(2634) },
                    { 2, 321, 2, null, new DateTime(2024, 12, 31, 12, 14, 41, 216, DateTimeKind.Local).AddTicks(2641) }
                });

            migrationBuilder.InsertData(
                table: "ReservationStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Pending" },
                    { 3, "Pending" },
                    { 4, "Pending" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "ReservationStatusId" },
                values: new object[] { new DateTime(2023, 12, 31, 12, 14, 41, 159, DateTimeKind.Local).AddTicks(9572), 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "ReservationStatusId" },
                values: new object[] { new DateTime(2023, 12, 31, 12, 14, 41, 159, DateTimeKind.Local).AddTicks(9585), 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTime", "ReservationStatusId" },
                values: new object[] { new DateTime(2023, 12, 31, 12, 14, 41, 159, DateTimeKind.Local).AddTicks(9586), 3 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTime", "ReservationStatusId" },
                values: new object[] { new DateTime(2023, 12, 31, 12, 14, 41, 159, DateTimeKind.Local).AddTicks(9588), 4 });

            migrationBuilder.InsertData(
                table: "RestaurantApplications",
                columns: new[] { "Id", "Cuisine", "CustomerId", "Description", "Email", "PhoneNumber", "RestaurantName", "StaffId", "Status" },
                values: new object[,]
                {
                    { 1, "Chinese", null, "good hotpot,must try!", "paradisehotpot@paradise.com", 63864838, "Paradise Hotpot", null, "Active" },
                    { 2, "Chinese", null, "good hotpot,must try!", "slfhotpot@slf.com", 62601838, "Shi Li Fang Hotpot", null, "Active" }
                });

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 12, 31, 12, 14, 41, 216, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 12, 31, 12, 14, 41, 216, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 12, 31, 12, 14, 41, 216, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 12, 31, 12, 14, 41, 216, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 12, 31, 12, 14, 41, 216, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 31, 12, 14, 41, 216, DateTimeKind.Local).AddTicks(2275), new DateTime(2023, 12, 31, 12, 14, 41, 216, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 31, 12, 14, 41, 216, DateTimeKind.Local).AddTicks(2277), new DateTime(2023, 12, 31, 12, 14, 41, 216, DateTimeKind.Local).AddTicks(2277) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReservationStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RestaurantApplications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RestaurantApplications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d215f5a1-f7f1-40d4-a29f-971a41910b50", "AQAAAAIAAYagAAAAEGR1Z5H8GoHskvKrbgRqTP9BQxn2dSxyVk13nNYpVlLonXjC3BpdttFbwsRsjwkG/Q==", "5edf10ad-66ac-403a-9408-021f869d50b4" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "ReservationStatusId" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 41, 25, 197, DateTimeKind.Local).AddTicks(887), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "ReservationStatusId" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 41, 25, 197, DateTimeKind.Local).AddTicks(897), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTime", "ReservationStatusId" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 41, 25, 197, DateTimeKind.Local).AddTicks(899), null });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTime", "ReservationStatusId" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 41, 25, 197, DateTimeKind.Local).AddTicks(900), null });

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(5050), new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(5052), new DateTime(2023, 12, 31, 11, 41, 25, 256, DateTimeKind.Local).AddTicks(5052) });
        }
    }
}
