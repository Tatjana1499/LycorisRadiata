using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class dodataDekoracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stavka_Kupac_KupacId",
                table: "Stavka");

            migrationBuilder.DropIndex(
                name: "IX_Stavka_KupacId",
                table: "Stavka");

            migrationBuilder.DropColumn(
                name: "KupacId",
                table: "Stavka");

            migrationBuilder.CreateTable(
                name: "Dekoracija",
                columns: table => new
                {
                    CvetProizvodId = table.Column<int>(type: "int", nullable: false),
                    CvetniAranzmanProizvodId = table.Column<int>(type: "int", nullable: false),
                    BrojCvetova = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dekoracija", x => new { x.CvetProizvodId, x.CvetniAranzmanProizvodId });
                    table.ForeignKey(
                        name: "FK_Dekoracija_Proizvod_CvetniAranzmanProizvodId",
                        column: x => x.CvetniAranzmanProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodId");
                    table.ForeignKey(
                        name: "FK_Dekoracija_Proizvod_CvetProizvodId",
                        column: x => x.CvetProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dekoracija_CvetniAranzmanProizvodId",
                table: "Dekoracija",
                column: "CvetniAranzmanProizvodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dekoracija");

            migrationBuilder.AddColumn<int>(
                name: "KupacId",
                table: "Stavka",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stavka_KupacId",
                table: "Stavka",
                column: "KupacId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stavka_Kupac_KupacId",
                table: "Stavka",
                column: "KupacId",
                principalTable: "Kupac",
                principalColumn: "KupacId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
