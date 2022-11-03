using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAB_Assignment2.Migrations
{
    public partial class LargeUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "siteRules",
                columns: table => new
                {
                    RuleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ÅbenIld = table.Column<string>(type: "TEXT", nullable: false),
                    HøjtMusik = table.Column<string>(type: "TEXT", nullable: false),
                    Overnatning = table.Column<string>(type: "TEXT", nullable: false),
                    FacilitysPK_FcName = table.Column<string>(type: "TEXT", nullable: true),
                    fk_FcName = table.Column<string>(type: "TEXT", nullable: false)
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
                name: "IX_siteRules_FacilitysPK_FcName",
                table: "siteRules",
                column: "FacilitysPK_FcName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "siteRules");
        }
    }
}
