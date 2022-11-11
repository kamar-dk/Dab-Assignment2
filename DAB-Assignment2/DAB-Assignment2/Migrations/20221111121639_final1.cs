using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_Assignment2.Migrations
{
    public partial class final1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_cityHallPersonels_CityHallPersonelEmpId",
                table: "Bookings");

            migrationBuilder.DropTable(
                name: "cityHallPersonels");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_CityHallPersonelEmpId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CityHallPersonelEmpId",
                table: "Bookings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityHallPersonelEmpId",
                table: "Bookings",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CityHallPersonelEmpId",
                table: "Bookings",
                column: "CityHallPersonelEmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_cityHallPersonels_CityHallPersonelEmpId",
                table: "Bookings",
                column: "CityHallPersonelEmpId",
                principalTable: "cityHallPersonels",
                principalColumn: "EmpId");
        }
    }
}
