using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class dodataSifraZaposlenog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SifraZaposlednog",
                table: "Administrator");

            migrationBuilder.AddColumn<string>(
                name: "SifraZaposlenog",
                table: "Administrator",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SifraZaposlenog",
                table: "Administrator");

            migrationBuilder.AddColumn<int>(
                name: "SifraZaposlednog",
                table: "Administrator",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
