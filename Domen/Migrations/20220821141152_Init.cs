using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kupac",
                columns: table => new
                {
                    KupacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lozinka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupac", x => x.KupacId);
                });

            migrationBuilder.CreateTable(
                name: "Narudzbina",
                columns: table => new
                {
                    NarudzbinaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VrstaNarudzbine = table.Column<int>(type: "int", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusIsporuke = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzbina", x => x.NarudzbinaId);
                });

            migrationBuilder.CreateTable(
                name: "Pakovanje",
                columns: table => new
                {
                    PakovanjeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Materijal = table.Column<int>(type: "int", nullable: false),
                    Oblik = table.Column<int>(type: "int", nullable: false),
                    Boja = table.Column<int>(type: "int", nullable: false),
                    Slika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pakovanje", x => x.PakovanjeId);
                });

            migrationBuilder.CreateTable(
                name: "ProdajnoMesto",
                columns: table => new
                {
                    ProdajnoMestoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RadnoVreme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sajt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slika = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdajnoMesto", x => x.ProdajnoMestoId);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    ProizvodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Familija = table.Column<int>(type: "int", nullable: true),
                    Slika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Boja = table.Column<int>(type: "int", nullable: true),
                    Sjaj = table.Column<int>(type: "int", nullable: true),
                    Masna = table.Column<bool>(type: "bit", nullable: true),
                    Namena = table.Column<int>(type: "int", nullable: true),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.ProizvodId);
                });

            migrationBuilder.CreateTable(
                name: "Stavka",
                columns: table => new
                {
                    RedniBroj = table.Column<int>(type: "int", nullable: false),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stavka", x => new { x.ProizvodId, x.RedniBroj });
                    table.ForeignKey(
                        name: "FK_Stavka_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kupac");

            migrationBuilder.DropTable(
                name: "Narudzbina");

            migrationBuilder.DropTable(
                name: "Pakovanje");

            migrationBuilder.DropTable(
                name: "ProdajnoMesto");

            migrationBuilder.DropTable(
                name: "Stavka");

            migrationBuilder.DropTable(
                name: "Proizvod");
        }
    }
}
