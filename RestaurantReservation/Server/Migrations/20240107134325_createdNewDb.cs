﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantReservation.Server.Migrations
{
    /// <inheritdoc />
    public partial class createdNewDb : Migration
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
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Building = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: true),
                    UnitNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: true)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: true)
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
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                name: "RestaurantApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cuisine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_RestaurantApplications_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id");
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
                    AddressId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    OpeningTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClosingTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    Rating = table.Column<int>(type: "int", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Building", "Level", "PostalCode", "Street", "UnitNumber" },
                values: new object[,]
                {
                    { 1, "Century Square", 2, 529509, "2 Tampines Central 5", "#02-22" },
                    { 2, "Parkroyal", 1, 199591, "7500 Beach Rd", null },
                    { 3, "VivoCity", 3, 98585, "1 HarbourFront Walk", "#03-08A" },
                    { 4, "Tampines 1", 2, 529536, " 10 Tampines Central 1", "#02-04" },
                    { 5, "One Raffles Place", 4, 48616, "1 Raffles Place", "#04-26/27/28" }
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
                values: new object[] { "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb", 0, "2d042eff-8d84-40ea-b601-45fcfc7c34e0", "admin@localhost.com", false, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECoMU1ZcFAF2ebUUURV11Dt+YCdKWQ37gEC31713DaVQ+aYhohoHgQDyMa/iiJ7ePQ==", null, false, "16cb3e27-3160-4abe-a401-0163a3f43eea", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CVV", "CardNumber", "CustomerId", "DateOfExpiry", "Name" },
                values: new object[,]
                {
                    { 1, 123, "1234123412341234", null, new DateTime(2025, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(8763), "Josh" },
                    { 2, 321, "1234123412341234", null, new DateTime(2025, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(8774), "Liza" }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "Code", "Description", "Discount", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, "NY2024", "New year discount!", 10.0, new DateTime(2024, 2, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9606), "NewYear", new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9604) },
                    { 2, "CNY2024", "Chinese New Year discount!", 10.0, new DateTime(2024, 3, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9611), "ChineseNewYear", new DateTime(2024, 2, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9610) },
                    { 3, "LOVE2024", "Valentine's discount!", 10.0, new DateTime(2024, 4, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9614), "Valentine", new DateTime(2024, 3, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9613) }
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

            migrationBuilder.InsertData(
                table: "RestaurantApplications",
                columns: new[] { "Id", "AddressId", "Cuisine", "CustomerId", "Description", "Email", "PhoneNumber", "RestaurantName", "StaffId", "Status" },
                values: new object[,]
                {
                    { 1, null, "Chinese", null, "good hotpot,must try!", "paradisehotpot@paradise.com", 63864838, "Paradise Hotpot", null, "Active" },
                    { 2, null, "Chinese", null, "good hotpot,must try!", "slfhotpot@slf.com", 62601838, "Shi Li Fang Hotpot", null, "Active" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "EndDate", "PlatformFee", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7746), 10.0, new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7744) },
                    { 2, new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7749), 10.0, new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7749) }
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
                    { 1, 1, "Hotpot", "Chinese", null, "images/haidilao.jpg", "East", "Hai Di Lao", 67804201, null, null },
                    { 2, 2, "Hotpot", "Chinese", null, "images/sichuandouhua.jpg", "Central", "Si Chuan Dou Hua", 67804201, null, null },
                    { 3, 3, "Hotpot", "Chinese", null, "images/beautyinthepot.jpg", "South", "Beauty In The Pot", 67804201, null, null },
                    { 4, 4, "Hotpot", "Chinese", null, "images/shabusai.jpg", "East", "Shabu Sai", 67804201, null, null },
                    { 5, 5, "Hotpot", "Chinese", null, "images/cityhotpot.jpg", "SouthWest", "City Hotpot", 67804201, null, null }
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
                    { 5, "images/cityhotpotMenu.jpg", 5 }
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
                    { 35, new DateTime(2024, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "Sunday", new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CustomerId", "DateTime", "Guest", "PromotionId", "Request", "ReservationStatusId", "RestaurantId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 7, 21, 43, 24, 994, DateTimeKind.Local).AddTicks(8019), 2, null, "None", 1, 1 },
                    { 2, null, new DateTime(2024, 1, 7, 21, 43, 24, 994, DateTimeKind.Local).AddTicks(8035), 3, null, "None", 2, 2 },
                    { 3, null, new DateTime(2024, 1, 7, 21, 43, 24, 994, DateTimeKind.Local).AddTicks(8036), 4, null, "None", 3, 3 },
                    { 4, null, new DateTime(2024, 1, 7, 21, 43, 24, 994, DateTimeKind.Local).AddTicks(8038), 2, null, "None", 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CustomerId", "DateTime", "Description", "Rating", "RestaurantId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9822), "Hai di lao staff very attentive", 4, 1 },
                    { 2, null, new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9825), "Good food", 4, 2 },
                    { 3, null, new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9826), "Nice soup", 4, 3 },
                    { 4, null, new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9828), "Cheap and affordable", 4, 4 },
                    { 5, null, new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(9829), "Great restaurant", 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "SeatingCapacities",
                columns: new[] { "Id", "Capacity", "Date", "RestaurantId" },
                values: new object[,]
                {
                    { 1, 15, new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7439), 1 },
                    { 2, 15, new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7455), 2 },
                    { 3, 15, new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7457), 3 },
                    { 4, 15, new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7458), 4 },
                    { 5, 15, new DateTime(2024, 1, 7, 21, 43, 25, 43, DateTimeKind.Local).AddTicks(7459), 5 }
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
                name: "IX_RestaurantApplications_StaffId",
                table: "RestaurantApplications",
                column: "StaffId");

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
                name: "Menus");

            migrationBuilder.DropTable(
                name: "OperatingHours");

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
                name: "SeatingCapacities");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "ReservationStatuses");

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
