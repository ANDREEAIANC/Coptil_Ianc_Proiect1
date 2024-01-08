using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coptil_Ianc_Proiect1.Migrations
{
    public partial class Migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Pisica_PisicaId",
                table: "Programare");

            migrationBuilder.DropTable(
                name: "Pisica");

            migrationBuilder.DropIndex(
                name: "IX_Programare_PisicaId",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "PisicaId",
                table: "Programare");

            migrationBuilder.RenameColumn(
                name: "Numar",
                table: "Programare",
                newName: "VarstaPisica");

            migrationBuilder.AddColumn<double>(
                name: "CantitateHrana",
                table: "Programare",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "GreutatePisica",
                table: "Programare",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NumePisica",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ObservatiiPisica",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RasaPisica",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SexPisica",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantitateHrana",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "GreutatePisica",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "NumePisica",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "ObservatiiPisica",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "RasaPisica",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "SexPisica",
                table: "Programare");

            migrationBuilder.RenameColumn(
                name: "VarstaPisica",
                table: "Programare",
                newName: "Numar");

            migrationBuilder.AddColumn<int>(
                name: "PisicaId",
                table: "Programare",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pisica",
                columns: table => new
                {
                    PisicaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersoanaId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Greutate = table.Column<int>(type: "int", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observatii = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersoanaId = table.Column<int>(type: "int", nullable: true),
                    Rasa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Varsta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pisica", x => x.PisicaId);
                    table.ForeignKey(
                        name: "FK_Pisica_AspNetUsers_PersoanaId1",
                        column: x => x.PersoanaId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Programare_PisicaId",
                table: "Programare",
                column: "PisicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pisica_PersoanaId1",
                table: "Pisica",
                column: "PersoanaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Pisica_PisicaId",
                table: "Programare",
                column: "PisicaId",
                principalTable: "Pisica",
                principalColumn: "PisicaId");
        }
    }
}
