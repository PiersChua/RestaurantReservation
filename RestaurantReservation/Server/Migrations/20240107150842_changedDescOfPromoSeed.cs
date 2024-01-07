using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Server.Migrations
{
    /// <inheritdoc />
    public partial class changedDescOfPromoSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PaymentMethods",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e169ac85-4a44-4a4b-9a5d-a13b2289f5f1", "AQAAAAIAAYagAAAAEOjW/CPdtjWFJqlngqOYtHUjnerO5iYcndCnMFRoIkJjrOT/Gx2QvwmTFFhdlocPgg==", "5f18d3bf-0864-4f36-812f-ed3bc486622e" });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfExpiry",
                value: new DateTime(2025, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfExpiry",
                value: new DateTime(2025, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Celebrate the New Year with fantastic deals! Enjoy exclusive discounts on all reservations. Start 2024 in style with limited-time offers and extra savings just for you. Renew, refresh, and rejoice! Reserve now and make this year unforgettable. Cheers to a fantastic 2024!", new DateTime(2024, 2, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(3798), new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Celebrate the Lunar New Year at Bookbite! Reserve your table now for an exquisite culinary journey featuring luck-filled banquets and exclusive dining packages. Indulge in authentic flavors that capture the essence of the season. Make your celebrations memorable with us. Gong Xi Fa Cai!", new DateTime(2024, 3, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(3805), new DateTime(2024, 2, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Celebrate love at Bookbite! Book your romantic evening for an unforgettable Valentine's experience. Indulge in exquisite dining with our special menu, crafted to ignite the flames of love. Enjoy a romantic ambiance and impeccable service, setting the stage for a memorable evening. Delight in exclusive dishes designed to make hearts flutter. Love is in the air at Bookbite!", new DateTime(2024, 4, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(3808), new DateTime(2024, 3, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 23, 8, 42, 452, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 23, 8, 42, 452, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 23, 8, 42, 452, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 23, 8, 42, 452, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(1962), new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(1965), new DateTime(2024, 1, 7, 23, 8, 42, 503, DateTimeKind.Local).AddTicks(1964) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PaymentMethods",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d042eff-8d84-40ea-b601-45fcfc7c34e0", "AQAAAAIAAYagAAAAECoMU1ZcFAF2ebUUURV11Dt+YCdKWQ37gEC31713DaVQ+aYhohoHgQDyMa/iiJ7ePQ==", "16cb3e27-3160-4abe-a401-0163a3f43eea" });

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfExpiry",
                value: new DateTime(2025, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfExpiry",
                value: new DateTime(2025, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "New year discount!", new DateTime(2024, 2, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9606), new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Chinese New Year discount!", new DateTime(2024, 3, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9611), new DateTime(2024, 2, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EndDate", "StartDate" },
                values: new object[] { "Valentine's discount!", new DateTime(2024, 4, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9614), new DateTime(2024, 3, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 21, 43, 24, 994, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 21, 43, 24, 994, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 21, 43, 24, 994, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 21, 43, 24, 994, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "SeatingCapacities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7746), new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7749), new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7749) });
        }
    }
}
