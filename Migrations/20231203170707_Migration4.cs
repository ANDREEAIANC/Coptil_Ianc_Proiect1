using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coptil_Ianc_Proiect1.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pisica_Persoana_PersoanaId",
                table: "Pisica");

            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Persoana_PersoanaId",
                table: "Programare");

            migrationBuilder.DropTable(
                name: "Persoana");

            migrationBuilder.DropIndex(
                name: "IX_Programare_PersoanaId",
                table: "Programare");

            migrationBuilder.DropIndex(
                name: "IX_Pisica_PersoanaId",
                table: "Pisica");

            migrationBuilder.AddColumn<string>(
                name: "PersoanaId1",
                table: "Programare",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersoanaId1",
                table: "Pisica",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Programare_PersoanaId1",
                table: "Programare",
                column: "PersoanaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pisica_PersoanaId1",
                table: "Pisica",
                column: "PersoanaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pisica_AspNetUsers_PersoanaId1",
                table: "Pisica",
                column: "PersoanaId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_AspNetUsers_PersoanaId1",
                table: "Programare",
                column: "PersoanaId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pisica_AspNetUsers_PersoanaId1",
                table: "Pisica");

            migrationBuilder.DropForeignKey(
                name: "FK_Programare_AspNetUsers_PersoanaId1",
                table: "Programare");

            migrationBuilder.DropIndex(
                name: "IX_Programare_PersoanaId1",
                table: "Programare");

            migrationBuilder.DropIndex(
                name: "IX_Pisica_PersoanaId1",
                table: "Pisica");

            migrationBuilder.DropColumn(
                name: "PersoanaId1",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "PersoanaId1",
                table: "Pisica");

            migrationBuilder.CreateTable(
                name: "Persoana",
                columns: table => new
                {
                    PersoanaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdresaDeEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumarTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observatii = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persoana", x => x.PersoanaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Programare_PersoanaId",
                table: "Programare",
                column: "PersoanaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pisica_PersoanaId",
                table: "Pisica",
                column: "PersoanaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pisica_Persoana_PersoanaId",
                table: "Pisica",
                column: "PersoanaId",
                principalTable: "Persoana",
                principalColumn: "PersoanaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Persoana_PersoanaId",
                table: "Programare",
                column: "PersoanaId",
                principalTable: "Persoana",
                principalColumn: "PersoanaId");
        }
    }
}
