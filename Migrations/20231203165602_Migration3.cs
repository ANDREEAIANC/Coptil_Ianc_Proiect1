using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coptil_Ianc_Proiect1.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantitateHrana",
                table: "Programare");

            migrationBuilder.AddColumn<int>(
                name: "TipHranaId",
                table: "Programare",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Programare_TipHranaId",
                table: "Programare",
                column: "TipHranaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_TipHrana_TipHranaId",
                table: "Programare",
                column: "TipHranaId",
                principalTable: "TipHrana",
                principalColumn: "TipHranaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programare_TipHrana_TipHranaId",
                table: "Programare");

            migrationBuilder.DropIndex(
                name: "IX_Programare_TipHranaId",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "TipHranaId",
                table: "Programare");

            migrationBuilder.AddColumn<int>(
                name: "CantitateHrana",
                table: "Programare",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
