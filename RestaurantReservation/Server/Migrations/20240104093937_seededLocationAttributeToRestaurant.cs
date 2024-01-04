using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Server.Migrations
{
    /// <inheritdoc />
    public partial class seededLocationAttributeToRestaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Location",
                value: "East");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Location",
                value: "Central");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "Location",
                value: "South");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "Location",
                value: "East");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                column: "Location",
                value: "SouthWest");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa229c4e-8f7d-4431-841d-752ede93fe4d", "AQAAAAIAAYagAAAAENi1awnSD2BG/5ZD9QxxL/qJcYeLZzBGIzXzYydaTPf/xrKJ9e4I7LGFyEVMApzg/g==", "7a38bd26-ff39-456a-a19c-45642ba48545" });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfExpiry",
                value: new DateTime(2025, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfExpiry",
                value: new DateTime(2025, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(5268), new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(5274), new DateTime(2024, 2, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(5277), new DateTime(2024, 3, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 17, 57, 57, 367, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 17, 57, 57, 367, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 17, 57, 57, 367, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 17, 57, 57, 367, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Location",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Location",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "Location",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "Location",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                column: "Location",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(3407), new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(3410), new DateTime(2024, 1, 3, 17, 57, 57, 416, DateTimeKind.Local).AddTicks(3409) });
        }
    }
}
