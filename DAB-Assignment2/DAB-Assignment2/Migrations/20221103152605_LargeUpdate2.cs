using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_Assignment2.Migrations
{
    public partial class LargeUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacilitysPK_FcName",
                table: "AvailableItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Facilitys",
                columns: table => new
                {
                    PK_FcName = table.Column<string>(type: "TEXT", nullable: false),
                    ClosetAdress = table.Column<string>(type: "TEXT", nullable: false),
                    FcType = table.Column<string>(type: "TEXT", nullable: false),
                    CanBeBookedBy = table.Column<string>(type: "TEXT", nullable: false),
                    FacilityDecrtiption = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilitys", x => x.PK_FcName);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailableItems_FacilitysPK_FcName",
                table: "AvailableItems",
                column: "FacilitysPK_FcName");

            migrationBuilder.AddForeignKey(
                name: "FK_AvailableItems_Facilitys_FacilitysPK_FcName",
                table: "AvailableItems",
                column: "FacilitysPK_FcName",
                principalTable: "Facilitys",
                principalColumn: "PK_FcName",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailableItems_Facilitys_FacilitysPK_FcName",
                table: "AvailableItems");

            migrationBuilder.DropTable(
                name: "Facilitys");

            migrationBuilder.DropIndex(
                name: "IX_AvailableItems_FacilitysPK_FcName",
                table: "AvailableItems");

            migrationBuilder.DropColumn(
                name: "FacilitysPK_FcName",
                table: "AvailableItems");
        }
    }
}
