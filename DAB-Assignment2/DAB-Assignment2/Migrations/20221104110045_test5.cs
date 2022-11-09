using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_Assignment2.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailableItems_Facilitys_FacilitysPK_FcName",
                table: "AvailableItems");

            migrationBuilder.DropIndex(
                name: "IX_AvailableItems_FacilitysPK_FcName",
                table: "AvailableItems");

            migrationBuilder.DropColumn(
                name: "FcName",
                table: "AvailableItems");

            migrationBuilder.AddColumn<int>(
                name: "AvItemId",
                table: "Facilitys",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RuleId",
                table: "Facilitys",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "FacilitysPK_FcName",
                table: "AvailableItems",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "siteRules",
                columns: table => new
                {
                    RuleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ÅbenIld = table.Column<string>(type: "TEXT", nullable: false),
                    HøjtMusik = table.Column<string>(type: "TEXT", nullable: false),
                    Overnatning = table.Column<string>(type: "TEXT", nullable: false),
                    FacilitysPK_FcName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteRules", x => x.RuleId);
                    table.ForeignKey(
                        name: "FK_siteRules_Facilitys_FacilitysPK_FcName",
                        column: x => x.FacilitysPK_FcName,
                        principalTable: "Facilitys",
                        principalColumn: "PK_FcName");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailableItems_FacilitysPK_FcName",
                table: "AvailableItems",
                column: "FacilitysPK_FcName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_siteRules_FacilitysPK_FcName",
                table: "siteRules",
                column: "FacilitysPK_FcName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AvailableItems_Facilitys_FacilitysPK_FcName",
                table: "AvailableItems",
                column: "FacilitysPK_FcName",
                principalTable: "Facilitys",
                principalColumn: "PK_FcName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailableItems_Facilitys_FacilitysPK_FcName",
                table: "AvailableItems");

            migrationBuilder.DropTable(
                name: "siteRules");

            migrationBuilder.DropIndex(
                name: "IX_AvailableItems_FacilitysPK_FcName",
                table: "AvailableItems");

            migrationBuilder.DropColumn(
                name: "AvItemId",
                table: "Facilitys");

            migrationBuilder.DropColumn(
                name: "RuleId",
                table: "Facilitys");

            migrationBuilder.AlterColumn<string>(
                name: "FacilitysPK_FcName",
                table: "AvailableItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FcName",
                table: "AvailableItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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
    }
}
