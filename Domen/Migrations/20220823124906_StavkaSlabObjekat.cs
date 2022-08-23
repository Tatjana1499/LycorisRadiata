using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class StavkaSlabObjekat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stavka",
                columns: table => new
                {
                    StavkaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NarudzbinaId = table.Column<int>(type: "int", nullable: false),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stavka", x => new { x.NarudzbinaId, x.StavkaId });
                    table.ForeignKey(
                        name: "FK_Stavka_Narudzbina_NarudzbinaId",
                        column: x => x.NarudzbinaId,
                        principalTable: "Narudzbina",
                        principalColumn: "NarudzbinaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stavka_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stavka_ProizvodId",
                table: "Stavka",
                column: "ProizvodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stavka");
        }
    }
}
