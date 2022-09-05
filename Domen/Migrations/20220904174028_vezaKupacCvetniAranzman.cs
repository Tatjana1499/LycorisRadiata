using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class vezaKupacCvetniAranzman : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slika",
                table: "ProdajnoMesto");

            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Pakovanje");

            migrationBuilder.AddColumn<int>(
                name: "KupacId",
                table: "CvetniAranzman",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CvetniAranzman_KupacId",
                table: "CvetniAranzman",
                column: "KupacId");

            migrationBuilder.AddForeignKey(
                name: "FK_CvetniAranzman_Kupac_KupacId",
                table: "CvetniAranzman",
                column: "KupacId",
                principalTable: "Kupac",
                principalColumn: "KupacId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CvetniAranzman_Kupac_KupacId",
                table: "CvetniAranzman");

            migrationBuilder.DropIndex(
                name: "IX_CvetniAranzman_KupacId",
                table: "CvetniAranzman");

            migrationBuilder.DropColumn(
                name: "KupacId",
                table: "CvetniAranzman");

            migrationBuilder.AddColumn<string>(
                name: "Slika",
                table: "ProdajnoMesto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slika",
                table: "Pakovanje",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
