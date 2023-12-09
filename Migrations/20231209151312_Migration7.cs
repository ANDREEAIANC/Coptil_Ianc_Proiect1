using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coptil_Ianc_Proiect1.Migrations
{
    public partial class Migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Programare");

            migrationBuilder.RenameColumn(
                name: "Ora",
                table: "Programare",
                newName: "DataSiOra");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataSiOra",
                table: "Programare",
                newName: "Ora");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Programare",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
