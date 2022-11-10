using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_Assignment2.Migrations
{
    public partial class Del1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cityHallPersonels",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cityHallPersonels", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "Facilitys",
                columns: table => new
                {
                    FcId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FcName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosetAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FcType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CanBeBookedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacilityDecrtiption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FcRule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FcItems = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilitys", x => x.FcId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FacilitysFcId = table.Column<int>(type: "int", nullable: false),
                    BookedFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookedTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityHallPersonelEmpId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Bookings_cityHallPersonels_CityHallPersonelEmpId",
                        column: x => x.CityHallPersonelEmpId,
                        principalTable: "cityHallPersonels",
                        principalColumn: "EmpId");
                    table.ForeignKey(
                        name: "FK_Bookings_Facilitys_FacilitysFcId",
                        column: x => x.FacilitysFcId,
                        principalTable: "Facilitys",
                        principalColumn: "FcId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Users_UserName",
                        column: x => x.UserName,
                        principalTable: "Users",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CityHallPersonelEmpId",
                table: "Bookings",
                column: "CityHallPersonelEmpId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_FacilitysFcId",
                table: "Bookings",
                column: "FacilitysFcId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserName",
                table: "Bookings",
                column: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "cityHallPersonels");

            migrationBuilder.DropTable(
                name: "Facilitys");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
