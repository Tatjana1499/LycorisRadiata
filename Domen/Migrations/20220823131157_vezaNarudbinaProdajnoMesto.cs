using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class vezaNarudbinaProdajnoMesto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzbina_ProdajnoMesto_ProdajnoMestoId",
                table: "Narudzbina");

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzbina_ProdajnoMesto_ProdajnoMestoId",
                table: "Narudzbina",
                column: "ProdajnoMestoId",
                principalTable: "ProdajnoMesto",
                principalColumn: "ProdajnoMestoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzbina_ProdajnoMesto_ProdajnoMestoId",
                table: "Narudzbina");

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzbina_ProdajnoMesto_ProdajnoMestoId",
                table: "Narudzbina",
                column: "ProdajnoMestoId",
                principalTable: "ProdajnoMesto",
                principalColumn: "ProdajnoMestoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
