using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedNametoPaymentMethod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PaymentMethods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86f04097-591e-4f08-a1fc-6eff3369ec22", "AQAAAAIAAYagAAAAEC2iYJvnZHq2qgs5rtZd2ZeaGrzR+fSLzMEE7n+iGM0LNAn1kC2CyvsclzGNWvjoLQ==", "ffa1aead-2456-4212-a99c-e0fd53a4915f" });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfExpiry", "Name" },
                values: new object[] { new DateTime(2025, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(6054), null });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfExpiry", "Name" },
                values: new object[] { new DateTime(2025, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(6064), null });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(7447), new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(7454), new DateTime(2024, 2, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(7456), new DateTime(2024, 3, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 16, 40, 4, 199, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 16, 40, 4, 199, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 16, 40, 4, 199, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 16, 40, 4, 199, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 1, 7, 16, 40, 4, 248, DateTimeKind.Local).AddTicks(5586) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "PaymentMethods");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b975ba5-1230-4e58-a1f2-5b5963082388", "AQAAAAIAAYagAAAAEN+qkGiylpkAZGwEstn8gA1pdUZq597i2yCfAEsitmLdjhD9Gd62f736BMFTn5aO7A==", "b630aedb-9e15-4836-a344-a9b63e5d0167" });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfExpiry",
                value: new DateTime(2025, 1, 4, 17, 39, 36, 702, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfExpiry",
                value: new DateTime(2025, 1, 4, 17, 39, 36, 702, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 4, 17, 39, 36, 703, DateTimeKind.Local).AddTicks(2506), new DateTime(2024, 1, 4, 17, 39, 36, 703, DateTimeKind.Local).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 4, 17, 39, 36, 703, DateTimeKind.Local).AddTicks(2520), new DateTime(2024, 2, 4, 17, 39, 36, 703, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 17, 39, 36, 703, DateTimeKind.Local).AddTicks(2526), new DateTime(2024, 3, 4, 17, 39, 36, 703, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 4, 17, 39, 36, 582, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 4, 17, 39, 36, 582, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 4, 17, 39, 36, 582, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 4, 17, 39, 36, 582, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 4, 17, 39, 36, 703, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 4, 17, 39, 36, 703, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 4, 17, 39, 36, 703, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 4, 17, 39, 36, 703, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 1, 4, 17, 39, 36, 703, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 4, 17, 39, 36, 702, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 4, 17, 39, 36, 702, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 1, 4, 17, 39, 36, 702, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 1, 4, 17, 39, 36, 702, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 1, 4, 17, 39, 36, 702, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 4, 17, 39, 36, 702, DateTimeKind.Local).AddTicks(8134), new DateTime(2024, 1, 4, 17, 39, 36, 702, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 4, 17, 39, 36, 702, DateTimeKind.Local).AddTicks(8140), new DateTime(2024, 1, 4, 17, 39, 36, 702, DateTimeKind.Local).AddTicks(8138) });
        }
    }
}
