using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coptil_Ianc_Proiect1.Migrations
{
    public partial class Migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programare_AspNetUsers_PersoanaId1",
                table: "Programare");

            migrationBuilder.DropIndex(
                name: "IX_Programare_PersoanaId1",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "PersoanaId",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "PersoanaId1",
                table: "Programare");

            migrationBuilder.RenameColumn(
                name: "ObservatiiPisica",
                table: "Programare",
                newName: "TelefonClient");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumeClient",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Observatii",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "NumeClient",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "Observatii",
                table: "Programare");

            migrationBuilder.RenameColumn(
                name: "TelefonClient",
                table: "Programare",
                newName: "ObservatiiPisica");

            migrationBuilder.AddColumn<int>(
                name: "PersoanaId",
                table: "Programare",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersoanaId1",
                table: "Programare",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Programare_PersoanaId1",
                table: "Programare",
                column: "PersoanaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_AspNetUsers_PersoanaId1",
                table: "Programare",
                column: "PersoanaId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
