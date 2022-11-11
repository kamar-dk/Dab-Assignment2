using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_Assignment2.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosetAdress",
                table: "Facilitys");

            migrationBuilder.AddColumn<double>(
                name: "GPS_lat",
                table: "Facilitys",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "GPS_lon",
                table: "Facilitys",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GPS_lat",
                table: "Facilitys");

            migrationBuilder.DropColumn(
                name: "GPS_lon",
                table: "Facilitys");

            migrationBuilder.AddColumn<string>(
                name: "ClosetAdress",
                table: "Facilitys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
