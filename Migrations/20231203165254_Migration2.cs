using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coptil_Ianc_Proiect1.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Hrana_HranaId",
                table: "Programare");

            migrationBuilder.DropTable(
                name: "Hrana");

            migrationBuilder.DropIndex(
                name: "IX_Programare_HranaId",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "HranaId",
                table: "Programare");

            migrationBuilder.AddColumn<int>(
                name: "CantitateHrana",
                table: "Programare",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantitateHrana",
                table: "Programare");

            migrationBuilder.AddColumn<int>(
                name: "HranaId",
                table: "Programare",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Hrana",
                columns: table => new
                {
                    HranaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipHranaId = table.Column<int>(type: "int", nullable: true),
                    Cantitate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hrana", x => x.HranaId);
                    table.ForeignKey(
                        name: "FK_Hrana_TipHrana_TipHranaId",
                        column: x => x.TipHranaId,
                        principalTable: "TipHrana",
                        principalColumn: "TipHranaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Programare_HranaId",
                table: "Programare",
                column: "HranaId");

            migrationBuilder.CreateIndex(
                name: "IX_Hrana_TipHranaId",
                table: "Hrana",
                column: "TipHranaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Hrana_HranaId",
                table: "Programare",
                column: "HranaId",
                principalTable: "Hrana",
                principalColumn: "HranaId");
        }
    }
}
