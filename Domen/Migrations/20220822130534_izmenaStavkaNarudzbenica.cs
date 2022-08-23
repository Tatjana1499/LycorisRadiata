using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class izmenaStavkaNarudzbenica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stavka",
                table: "Stavka");

            migrationBuilder.DropIndex(
                name: "IX_Stavka_NarudzbinaId",
                table: "Stavka");

            migrationBuilder.DropColumn(
                name: "DatumKreiranja",
                table: "Stavka");

            migrationBuilder.AddColumn<int>(
                name: "KupacId",
                table: "Narudzbina",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stavka",
                table: "Stavka",
                columns: new[] { "NarudzbinaId", "RedniBroj" });

            migrationBuilder.CreateIndex(
                name: "IX_Stavka_ProizvodId",
                table: "Stavka",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzbina_KupacId",
                table: "Narudzbina",
                column: "KupacId");

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzbina_Kupac_KupacId",
                table: "Narudzbina",
                column: "KupacId",
                principalTable: "Kupac",
                principalColumn: "KupacId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzbina_Kupac_KupacId",
                table: "Narudzbina");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stavka",
                table: "Stavka");

            migrationBuilder.DropIndex(
                name: "IX_Stavka_ProizvodId",
                table: "Stavka");

            migrationBuilder.DropIndex(
                name: "IX_Narudzbina_KupacId",
                table: "Narudzbina");

            migrationBuilder.DropColumn(
                name: "KupacId",
                table: "Narudzbina");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumKreiranja",
                table: "Stavka",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stavka",
                table: "Stavka",
                columns: new[] { "ProizvodId", "RedniBroj" });

            migrationBuilder.CreateIndex(
                name: "IX_Stavka_NarudzbinaId",
                table: "Stavka",
                column: "NarudzbinaId");
        }
    }
}
