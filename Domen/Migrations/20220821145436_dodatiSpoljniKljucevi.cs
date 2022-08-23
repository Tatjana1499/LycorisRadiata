using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class dodatiSpoljniKljucevi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KupacId",
                table: "Stavka",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NarudzbinaId",
                table: "Stavka",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PakovanjeId",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdajnoMestoId",
                table: "Narudzbina",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stavka_KupacId",
                table: "Stavka",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Stavka_NarudzbinaId",
                table: "Stavka",
                column: "NarudzbinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_PakovanjeId",
                table: "Proizvod",
                column: "PakovanjeId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzbina_ProdajnoMestoId",
                table: "Narudzbina",
                column: "ProdajnoMestoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzbina_ProdajnoMesto_ProdajnoMestoId",
                table: "Narudzbina",
                column: "ProdajnoMestoId",
                principalTable: "ProdajnoMesto",
                principalColumn: "ProdajnoMestoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Pakovanje_PakovanjeId",
                table: "Proizvod",
                column: "PakovanjeId",
                principalTable: "Pakovanje",
                principalColumn: "PakovanjeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stavka_Kupac_KupacId",
                table: "Stavka",
                column: "KupacId",
                principalTable: "Kupac",
                principalColumn: "KupacId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stavka_Narudzbina_NarudzbinaId",
                table: "Stavka",
                column: "NarudzbinaId",
                principalTable: "Narudzbina",
                principalColumn: "NarudzbinaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzbina_ProdajnoMesto_ProdajnoMestoId",
                table: "Narudzbina");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Pakovanje_PakovanjeId",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Stavka_Kupac_KupacId",
                table: "Stavka");

            migrationBuilder.DropForeignKey(
                name: "FK_Stavka_Narudzbina_NarudzbinaId",
                table: "Stavka");

            migrationBuilder.DropIndex(
                name: "IX_Stavka_KupacId",
                table: "Stavka");

            migrationBuilder.DropIndex(
                name: "IX_Stavka_NarudzbinaId",
                table: "Stavka");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_PakovanjeId",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Narudzbina_ProdajnoMestoId",
                table: "Narudzbina");

            migrationBuilder.DropColumn(
                name: "KupacId",
                table: "Stavka");

            migrationBuilder.DropColumn(
                name: "NarudzbinaId",
                table: "Stavka");

            migrationBuilder.DropColumn(
                name: "PakovanjeId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "ProdajnoMestoId",
                table: "Narudzbina");
        }
    }
}
