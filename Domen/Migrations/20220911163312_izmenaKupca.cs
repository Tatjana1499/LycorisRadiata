using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class izmenaKupca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojTelefona",
                table: "Kupac");

            migrationBuilder.AddColumn<int>(
                name: "BrojNarudzbina",
                table: "Kupac",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumKreiranjaNaloga",
                table: "Kupac",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojNarudzbina",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "DatumKreiranjaNaloga",
                table: "Kupac");

            migrationBuilder.AddColumn<string>(
                name: "BrojTelefona",
                table: "Kupac",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
