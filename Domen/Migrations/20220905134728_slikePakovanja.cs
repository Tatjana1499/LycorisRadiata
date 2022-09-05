using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class slikePakovanja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slika",
                table: "Pakovanje",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Pakovanje");
        }
    }
}
