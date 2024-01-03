using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Server.Migrations
{
    /// <inheritdoc />
    public partial class ReseedForMenuOHPromoReview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fadeae77-6a0f-450e-bb0a-ecbd6da103ea", "AQAAAAIAAYagAAAAEBuUMBUiZKsfD+efYcHHo2kOc19+OrZSGFSjlOQ/MdATNrZICec7oKLSxZNKJZNDQg==", "be2df61f-996e-457e-95de-6662101ec279" });

            migrationBuilder.UpdateData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 30,
                column: "RestaurantId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfExpiry",
                value: new DateTime(2025, 1, 3, 16, 56, 6, 180, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfExpiry",
                value: new DateTime(2025, 1, 3, 16, 56, 6, 180, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 3, 16, 56, 6, 181, DateTimeKind.Local).AddTicks(870), new DateTime(2024, 1, 3, 16, 56, 6, 181, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 3, 16, 56, 6, 181, DateTimeKind.Local).AddTicks(876), new DateTime(2024, 2, 3, 16, 56, 6, 181, DateTimeKind.Local).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 56, 6, 181, DateTimeKind.Local).AddTicks(878), new DateTime(2024, 3, 3, 16, 56, 6, 181, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 16, 56, 6, 119, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 16, 56, 6, 119, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 16, 56, 6, 119, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 16, 56, 6, 119, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "Description" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 56, 6, 181, DateTimeKind.Local).AddTicks(1068), "Hai di lao staff very attentive" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "Description" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 56, 6, 181, DateTimeKind.Local).AddTicks(1070), "Good food" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTime", "Description" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 56, 6, 181, DateTimeKind.Local).AddTicks(1071), "Nice soup" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTime", "Description" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 56, 6, 181, DateTimeKind.Local).AddTicks(1073), "Cheap and affordable" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateTime", "Description" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 56, 6, 181, DateTimeKind.Local).AddTicks(1074), "Great restaurant" });

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 3, 16, 56, 6, 180, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 3, 16, 56, 6, 180, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 1, 3, 16, 56, 6, 180, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 1, 3, 16, 56, 6, 180, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 1, 3, 16, 56, 6, 180, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 56, 6, 180, DateTimeKind.Local).AddTicks(8854), new DateTime(2024, 1, 3, 16, 56, 6, 180, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 56, 6, 180, DateTimeKind.Local).AddTicks(8856), new DateTime(2024, 1, 3, 16, 56, 6, 180, DateTimeKind.Local).AddTicks(8855) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e0419f3-4b16-4823-a8b6-44509e34abc4", "AQAAAAIAAYagAAAAEHa6wC3BDPKeL50XpeWk4TsB1yO1OtjXA/JT9/O7pqpkAJ1F4K2LSSpyowTYsdL4KA==", "1451baad-84e2-46cc-ad82-f080bdb6ba42" });

            migrationBuilder.UpdateData(
                table: "OperatingHours",
                keyColumn: "Id",
                keyValue: 30,
                column: "RestaurantId",
                value: 3);

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

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(7618), new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(7628), new DateTime(2024, 2, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(7630), new DateTime(2024, 3, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(7629) });

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

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "Description" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(8304), "description" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "Description" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(8312), "description" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTime", "Description" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(8316), "description" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTime", "Description" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(8318), "description" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateTime", "Description" },
                values: new object[] { new DateTime(2024, 1, 3, 16, 48, 37, 293, DateTimeKind.Local).AddTicks(8323), "description" });

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
    }
}
