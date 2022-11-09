using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_Assignment2.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingsBookingId",
                table: "Facilitys",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "cityHallPersonels",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookingId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmpName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cityHallPersonels", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "AvailableItems",
                columns: table => new
                {
                    AvItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FcName = table.Column<string>(type: "TEXT", nullable: false),
                    FacilitysPK_FcName = table.Column<string>(type: "TEXT", nullable: false),
                    EmpId = table.Column<int>(type: "INTEGER", nullable: false),
                    CityHallPersonelEmpId = table.Column<int>(type: "INTEGER", nullable: false),
                    Stole = table.Column<string>(type: "TEXT", nullable: false),
                    Grill = table.Column<string>(type: "TEXT", nullable: false),
                    Projector = table.Column<string>(type: "TEXT", nullable: false),
                    Brænde = table.Column<string>(type: "TEXT", nullable: false),
                    LastMaintanice = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    NextMaintanice = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableItems", x => x.AvItemId);
                    table.ForeignKey(
                        name: "FK_AvailableItems_cityHallPersonels_CityHallPersonelEmpId",
                        column: x => x.CityHallPersonelEmpId,
                        principalTable: "cityHallPersonels",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvailableItems_Facilitys_FacilitysPK_FcName",
                        column: x => x.FacilitysPK_FcName,
                        principalTable: "Facilitys",
                        principalColumn: "PK_FcName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookedBy = table.Column<string>(type: "TEXT", nullable: false),
                    BookedFcName = table.Column<string>(type: "TEXT", nullable: false),
                    BookedFrom = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    BookedTo = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: false),
                    CityHallPersonelEmpId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Bookings_cityHallPersonels_CityHallPersonelEmpId",
                        column: x => x.CityHallPersonelEmpId,
                        principalTable: "cityHallPersonels",
                        principalColumn: "EmpId");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    UserEmail = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    UserType = table.Column<string>(type: "TEXT", nullable: false),
                    CVR = table.Column<string>(type: "TEXT", nullable: false),
                    BookingsBookingId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserName);
                    table.ForeignKey(
                        name: "FK_Users_Bookings_BookingsBookingId",
                        column: x => x.BookingsBookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facilitys_BookingsBookingId",
                table: "Facilitys",
                column: "BookingsBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableItems_CityHallPersonelEmpId",
                table: "AvailableItems",
                column: "CityHallPersonelEmpId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableItems_FacilitysPK_FcName",
                table: "AvailableItems",
                column: "FacilitysPK_FcName");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CityHallPersonelEmpId",
                table: "Bookings",
                column: "CityHallPersonelEmpId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BookingsBookingId",
                table: "Users",
                column: "BookingsBookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facilitys_Bookings_BookingsBookingId",
                table: "Facilitys",
                column: "BookingsBookingId",
                principalTable: "Bookings",
                principalColumn: "BookingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facilitys_Bookings_BookingsBookingId",
                table: "Facilitys");

            migrationBuilder.DropTable(
                name: "AvailableItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "cityHallPersonels");

            migrationBuilder.DropIndex(
                name: "IX_Facilitys_BookingsBookingId",
                table: "Facilitys");

            migrationBuilder.DropColumn(
                name: "BookingsBookingId",
                table: "Facilitys");
        }
    }
}
