using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantReservation.Server.Migrations
{
    /// <inheritdoc />
    public partial class newdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Building = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    UnitNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NRIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformFee = table.Column<double>(type: "float", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfExpiry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CVV = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RestaurantOwners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantOwners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantOwners_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cuisine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    RestaurantOwnerId = table.Column<int>(type: "int", nullable: true),
                    SubscriptionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurants_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Restaurants_RestaurantOwners_RestaurantOwnerId",
                        column: x => x.RestaurantOwnerId,
                        principalTable: "RestaurantOwners",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Restaurants_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favourites_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Favourites_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OperatingHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperatingHours_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Guest = table.Column<int>(type: "int", nullable: false),
                    Request = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: true),
                    PromotionId = table.Column<int>(type: "int", nullable: true),
                    ReservationStatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_ReservationStatuses_ReservationStatusId",
                        column: x => x.ReservationStatusId,
                        principalTable: "ReservationStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SeatingCapacities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatingCapacities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeatingCapacities_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RestaurantApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cuisine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: true),
                    OperatingHourId = table.Column<int>(type: "int", nullable: true),
                    SeatingCapacityId = table.Column<int>(type: "int", nullable: true),
                    SubscriptionId = table.Column<int>(type: "int", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantApplications_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RestaurantApplications_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RestaurantApplications_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RestaurantApplications_OperatingHours_OperatingHourId",
                        column: x => x.OperatingHourId,
                        principalTable: "OperatingHours",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RestaurantApplications_SeatingCapacities_SeatingCapacityId",
                        column: x => x.SeatingCapacityId,
                        principalTable: "SeatingCapacities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RestaurantApplications_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RestaurantApplications_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Building", "Level", "PostalCode", "Street", "UnitNumber" },
                values: new object[,]
                {
                    { 1, "Century Square", 2, 529509, "2 Tampines Central 5", "#02-22" },
                    { 2, "Parkroyal", 1, 199591, "7500 Beach Rd", null },
                    { 3, "VivoCity", 3, 98585, "1 HarbourFront Walk", "#03-08A" },
                    { 4, "Tampines 1", 2, 529536, " 10 Tampines Central 1", "#02-04" },
                    { 5, "One Raffles Place", 4, 48616, "1 Raffles Place", "#04-26/27/28" },
                    { 6, "Oriental plaza", 1, 88756, "291 New Bridge Rd", "#01-01" },
                    { 7, "NTUC Income Tampines Junction", 1, 529653, "300 Tampines Ave 5", "#01-06" },
                    { 8, "AMK Hub", 4, 569933, "53 Ang Mo Kio Ave 3", "#04-04" },
                    { 9, "Plaza Singapura", 2, 238839, " 68 Orchard Rd", "#02-01" },
                    { 10, "Tampines Mall", 4, 529510, "4 Tampines Central 5", "#04-01" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69d41a28-6af8-47fe-aa0c-7785bd7233f5", null, "Staff", "STAFF" },
                    { "f0926ab0-0927-48bb-8f5a-92a5d1acbade", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb", 0, "ba9d54d7-38b5-4c1c-8577-dc4df310f493", "admin@localhost.com", false, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEB7zeiC/uxt8T6p6sXKSdC9rL60/5OUfddHp2dyxKo3g9HCWiiBfESxVLQ6Ae/85nA==", null, false, "7ee244a0-cd57-4639-b495-3caebab7de6b", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CVV", "CardNumber", "CustomerId", "DateOfExpiry", "Name" },
                values: new object[,]
                {
                    { 1, 123, "1234123412341234", null, new DateTime(2025, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(877), "Josh" },
                    { 2, 321, "1234123412341234", null, new DateTime(2025, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(888), "Liza" }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "Code", "Description", "Discount", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, "NY2024", "Celebrate the New Year with fantastic deals! Enjoy exclusive discounts on all reservations. Start 2024 in style with limited-time offers and extra savings just for you. Renew, refresh, and rejoice! Reserve now and make this year unforgettable. Cheers to a fantastic 2024!", 10.0, new DateTime(2024, 2, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(1812), "NewYear", new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(1810) },
                    { 2, "CNY2024", "Celebrate the Lunar New Year at Bookbite! Reserve your table now for an exquisite culinary journey featuring luck-filled banquets and exclusive dining packages. Indulge in authentic flavors that capture the essence of the season. Make your celebrations memorable with us. Gong Xi Fa Cai!", 10.0, new DateTime(2024, 3, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(1817), "ChineseNewYear", new DateTime(2024, 2, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(1816) },
                    { 3, "LOVE2024", "Celebrate love at Bookbite! Book your romantic evening for an unforgettable Valentine's experience. Indulge in exquisite dining with our special menu, crafted to ignite the flames of love. Enjoy a romantic ambiance and impeccable service, setting the stage for a memorable evening. Delight in exclusive dishes designed to make hearts flutter. Love is in the air at Bookbite!", 10.0, new DateTime(2024, 4, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(1820), "Valentine", new DateTime(2024, 3, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(1819) }
                });

            migrationBuilder.InsertData(
                table: "ReservationStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Confirmed" },
                    { 2, "Cancelled" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantApplications",
                columns: new[] { "Id", "AddressId", "Category", "Cuisine", "CustomerId", "Description", "Email", "ImagePath", "Location", "MenuId", "OperatingHourId", "PhoneNumber", "RestaurantName", "SeatingCapacityId", "StaffId", "Status", "SubscriptionId" },
                values: new object[,]
                {
                    { 1, null, "Hotpot", "Chinese", null, "good hotpot,must try!", "paradisehotpot@paradise.com", "images/noImage.jpg", "East", null, null, 63864838, "Paradise Hotpot", null, null, "Active", null },
                    { 2, null, "Hotpot", "Chinese", null, "good hotpot,must try!", "slfhotpot@slf.com", "images/noImage.jpg", "East", null, null, 62601838, "Shi Li Fang Hotpot", null, null, "Active", null },
                    { 3, null, "BBQ", "Korea", null, "good bbq,100% must try!", "ManNa@koreanBBQ.com", "images/noImage.jpg", "East", null, null, 62601838, "ManNa Korean BBQ", null, null, "Active", null }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "EndDate", "PlatformFee", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 18, 16, 10, 35, 603, DateTimeKind.Local).AddTicks(9864), 10.0, new DateTime(2024, 1, 18, 16, 10, 35, 603, DateTimeKind.Local).AddTicks(9863) },
                    { 2, new DateTime(2024, 1, 18, 16, 10, 35, 603, DateTimeKind.Local).AddTicks(9867), 10.0, new DateTime(2024, 1, 18, 16, 10, 35, 603, DateTimeKind.Local).AddTicks(9866) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "69d41a28-6af8-47fe-aa0c-7785bd7233f5", "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "AddressId", "Category", "Cuisine", "Email", "ImagePath", "Location", "Name", "PhoneNumber", "RestaurantOwnerId", "SubscriptionId" },
                values: new object[,]
                {
                    { 1, 1, "Hotpot", "Chinese", "admissions@tp.edu.sg", "images/haidilao.jpg", "East", "Hai Di Lao", 67804201, null, null },
                    { 2, 2, "Hotpot", "Chinese", "admissions@tp.edu.sg", "images/sichuandouhua.jpg", "Central", "Si Chuan Dou Hua", 67804201, null, null },
                    { 3, 3, "Hotpot", "Chinese", "admissions@tp.edu.sg", "images/beautyinthepot.jpg", "South", "Beauty In The Pot", 67804201, null, null },
                    { 4, 4, "Hotpot", "Chinese", "admissions@tp.edu.sg", "images/shabusai.jpg", "East", "Shabu Sai", 67804201, null, null },
                    { 5, 5, "Hotpot", "Chinese", "admissions@tp.edu.sg", "images/cityhotpot.jpg", "SouthWest", "City Hotpot", 67804201, null, null },
                    { 6, 6, "BBQ", "Korea", "admissions@tp.edu.sg", "images/ssikkek.jpg", "Central", "Ssikkek", 67804201, null, null },
                    { 7, 7, "BBQ", "Korea", "admissions@tp.edu.sg", "images/captainkim.jpg", "East", "Captain Kim", 67804201, null, null },
                    { 8, 8, "BBQ", "Korea", "admissions@tp.edu.sg", "images/imkimkorean.jpg", "North", "I'm Kim Korean", 67804201, null, null },
                    { 9, 9, "BBQ", "Korea", "admissions@tp.edu.sg", "images/seorae.jpg", "Central", "Seorae", 67804201, null, null },
                    { 10, 10, "BBQ", "Korea", "admissions@tp.edu.sg", "images/seoulgarden.jpg", "East", "Seoul Garden", 67804201, null, null }
                });

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

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "ImagePath", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "images/haidilaoMenu.jpg", 1 },
                    { 2, "images/sichuandouhuaMenu.jpg", 2 },
                    { 3, "images/beautyinthepotMenu.jpg", 3 },
                    { 4, "images/shabusaiMenu.jpg", 4 },
                    { 5, "images/cityhotpotMenu.jpg", 5 },
                    { 6, "images/ssikkekMenu.jpg", 6 },
                    { 7, "images/captainkimMenu.jpeg", 7 },
                    { 8, "images/imkimkoreanMenu.jpg", 8 },
                    { 9, "images/seoraeMenu.jpg", 9 },
                    { 10, "images/seoulgardenMenu.png", 10 }
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
                    { 30, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 31, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 32, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 33, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Friday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 34, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 35, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 36, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Monday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 37, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 38, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 39, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 40, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Friday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 41, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 42, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 43, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Monday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 44, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 45, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 46, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 47, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Friday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 48, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 49, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 50, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Monday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 51, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 52, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 53, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 54, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Friday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 55, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 56, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 57, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Monday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 58, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 59, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 60, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 61, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Friday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 62, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 63, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 64, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Monday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 65, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Tuesday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 66, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Wednesday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 67, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Thursday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 68, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Friday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 69, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Saturday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 70, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", new DateTime(2024, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 10 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "Date", "Guest", "PromotionId", "Request", "ReservationStatusId", "RestaurantId", "Time" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 18, 16, 10, 35, 555, DateTimeKind.Local).AddTicks(5647), 2, null, "None", 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(2024, 1, 18, 16, 10, 35, 555, DateTimeKind.Local).AddTicks(5668), 3, null, "None", 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(2024, 1, 18, 16, 10, 35, 555, DateTimeKind.Local).AddTicks(5670), 4, null, "None", 1, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(2024, 1, 18, 16, 10, 35, 555, DateTimeKind.Local).AddTicks(5672), 2, null, "None", 1, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CustomerId", "DateTime", "Description", "Rating", "RestaurantId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(1992), "Hai di lao staff very attentive", 4, 1 },
                    { 2, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(1995), "Good food", 4, 2 },
                    { 3, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(1997), "Nice soup", 4, 3 },
                    { 4, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(1998), "Cheap and affordable", 4, 4 },
                    { 5, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2000), "Great restaurant", 4, 5 },
                    { 6, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2001), "Excellent service and outstanding food!", 5, 1 },
                    { 7, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2005), "Good experience with room for improvement", 3, 1 },
                    { 8, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2006), "Disappointing experience. Not recommended.", 1, 2 },
                    { 9, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2007), "Amazing ambiance and top-notch cuisine!", 5, 2 },
                    { 10, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2008), "Satisfactory visit but lacks a wow factor.", 2, 3 },
                    { 11, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2010), "Unpleasant experience. Would not recommend", 1, 3 },
                    { 12, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2011), "Satisfactory visit but lacks a wow factor.", 1, 4 },
                    { 13, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2012), "Outstanding service and exquisite dishes!", 5, 4 },
                    { 14, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2013), "Poor service and disappointing menu", 1, 5 },
                    { 15, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2015), "Exceptional dining experience with impeccable service!", 5, 5 },
                    { 16, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2016), "Superb service and a menu that delights the taste buds!", 5, 6 },
                    { 17, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2017), "Adequate experience, but lacks a special touch", 3, 6 },
                    { 18, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2018), "Awful service and disappointing overall.", 1, 6 },
                    { 19, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2020), "Superb service and a menu that delights the taste buds!", 5, 7 },
                    { 20, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2021), "Adequate experience, but lacks a special touch", 3, 7 },
                    { 21, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2022), "Awful service and disappointing overall.", 1, 7 },
                    { 22, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2023), "Superb service and a menu that delights the taste buds!", 5, 8 },
                    { 23, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2025), "Adequate experience, but lacks a special touch", 3, 8 },
                    { 24, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2026), "Awful service and disappointing overall.", 1, 8 },
                    { 25, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2089), "Superb service and a menu that delights the taste buds!", 5, 9 },
                    { 26, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2091), "Adequate experience, but lacks a special touch", 3, 9 },
                    { 27, null, new DateTime(2024, 1, 18, 16, 10, 35, 604, DateTimeKind.Local).AddTicks(2092), "Awful service and disappointing overall.", 1, 9 }
                });

            migrationBuilder.InsertData(
                table: "SeatingCapacities",
                columns: new[] { "Id", "Capacity", "Date", "RestaurantId" },
                values: new object[,]
                {
                    { 1, 15, new DateTime(2024, 1, 18, 16, 10, 35, 603, DateTimeKind.Local).AddTicks(9637), 1 },
                    { 2, 15, new DateTime(2024, 1, 18, 16, 10, 35, 603, DateTimeKind.Local).AddTicks(9651), 2 },
                    { 3, 15, new DateTime(2024, 1, 18, 16, 10, 35, 603, DateTimeKind.Local).AddTicks(9653), 3 },
                    { 4, 15, new DateTime(2024, 1, 18, 16, 10, 35, 603, DateTimeKind.Local).AddTicks(9654), 4 },
                    { 5, 15, new DateTime(2024, 1, 18, 16, 10, 35, 603, DateTimeKind.Local).AddTicks(9655), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_CustomerId",
                table: "Favourites",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_RestaurantId",
                table: "Favourites",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_RestaurantId",
                table: "Menus",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingHours_RestaurantId",
                table: "OperatingHours",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_CustomerId",
                table: "PaymentMethods",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PromotionId",
                table: "Reservations",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationStatusId",
                table: "Reservations",
                column: "ReservationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RestaurantId",
                table: "Reservations",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantApplications_AddressId",
                table: "RestaurantApplications",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantApplications_CustomerId",
                table: "RestaurantApplications",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantApplications_MenuId",
                table: "RestaurantApplications",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantApplications_OperatingHourId",
                table: "RestaurantApplications",
                column: "OperatingHourId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantApplications_SeatingCapacityId",
                table: "RestaurantApplications",
                column: "SeatingCapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantApplications_StaffId",
                table: "RestaurantApplications",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantApplications_SubscriptionId",
                table: "RestaurantApplications",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantOwners_CustomerId",
                table: "RestaurantOwners",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_AddressId",
                table: "Restaurants",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_RestaurantOwnerId",
                table: "Restaurants",
                column: "RestaurantOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_SubscriptionId",
                table: "Restaurants",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RestaurantId",
                table: "Reviews",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatingCapacities_RestaurantId",
                table: "SeatingCapacities",
                column: "RestaurantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "RestaurantApplications");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "ReservationStatuses");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "OperatingHours");

            migrationBuilder.DropTable(
                name: "SeatingCapacities");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "RestaurantOwners");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
