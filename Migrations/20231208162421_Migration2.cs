using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coptil_Ianc_Proiect1.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TipProgramare",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipProgramare",
                table: "Programare");
        }
    }
}
