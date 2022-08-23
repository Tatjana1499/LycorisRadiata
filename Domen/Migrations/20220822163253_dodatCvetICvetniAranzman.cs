using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class dodatCvetICvetniAranzman : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dekoracija_Proizvod_CvetniAranzmanProizvodId",
                table: "Dekoracija");

            migrationBuilder.DropForeignKey(
                name: "FK_Dekoracija_Proizvod_CvetProizvodId",
                table: "Dekoracija");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Pakovanje_PakovanjeId",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_PakovanjeId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Boja",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Familija",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Masna",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Namena",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Napomena",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Opis",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "PakovanjeId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Sjaj",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Proizvod");

            migrationBuilder.CreateTable(
                name: "Cvet",
                columns: table => new
                {
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Familija = table.Column<int>(type: "int", nullable: false),
                    Slika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Boja = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cvet", x => x.ProizvodId);
                    table.ForeignKey(
                        name: "FK_Cvet_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CvetniAranzman",
                columns: table => new
                {
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    Sjaj = table.Column<int>(type: "int", nullable: false),
                    Masna = table.Column<bool>(type: "bit", nullable: false),
                    Namena = table.Column<int>(type: "int", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PakovanjeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CvetniAranzman", x => x.ProizvodId);
                    table.ForeignKey(
                        name: "FK_CvetniAranzman_Pakovanje_PakovanjeId",
                        column: x => x.PakovanjeId,
                        principalTable: "Pakovanje",
                        principalColumn: "PakovanjeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CvetniAranzman_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CvetniAranzman_PakovanjeId",
                table: "CvetniAranzman",
                column: "PakovanjeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dekoracija_Cvet_CvetProizvodId",
                table: "Dekoracija",
                column: "CvetProizvodId",
                principalTable: "Cvet",
                principalColumn: "ProizvodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dekoracija_CvetniAranzman_CvetniAranzmanProizvodId",
                table: "Dekoracija",
                column: "CvetniAranzmanProizvodId",
                principalTable: "CvetniAranzman",
                principalColumn: "ProizvodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dekoracija_Cvet_CvetProizvodId",
                table: "Dekoracija");

            migrationBuilder.DropForeignKey(
                name: "FK_Dekoracija_CvetniAranzman_CvetniAranzmanProizvodId",
                table: "Dekoracija");

            migrationBuilder.DropTable(
                name: "Cvet");

            migrationBuilder.DropTable(
                name: "CvetniAranzman");

            migrationBuilder.AddColumn<int>(
                name: "Boja",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Proizvod",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Familija",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Masna",
                table: "Proizvod",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Namena",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Napomena",
                table: "Proizvod",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Opis",
                table: "Proizvod",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PakovanjeId",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sjaj",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slika",
                table: "Proizvod",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_PakovanjeId",
                table: "Proizvod",
                column: "PakovanjeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dekoracija_Proizvod_CvetniAranzmanProizvodId",
                table: "Dekoracija",
                column: "CvetniAranzmanProizvodId",
                principalTable: "Proizvod",
                principalColumn: "ProizvodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dekoracija_Proizvod_CvetProizvodId",
                table: "Dekoracija",
                column: "CvetProizvodId",
                principalTable: "Proizvod",
                principalColumn: "ProizvodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Pakovanje_PakovanjeId",
                table: "Proizvod",
                column: "PakovanjeId",
                principalTable: "Pakovanje",
                principalColumn: "PakovanjeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
