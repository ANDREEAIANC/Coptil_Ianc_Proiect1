using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coptil_Ianc_Proiect1.Migrations
{
    public partial class Migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Camera_CameraId",
                table: "Programare");

            migrationBuilder.DropForeignKey(
                name: "FK_Programare_TipHrana_TipHranaId",
                table: "Programare");

            migrationBuilder.DropIndex(
                name: "IX_Programare_CameraId",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "CameraId",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "CantitateHrana",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "DataIesire",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "DataIntrare",
                table: "Programare");

            migrationBuilder.RenameColumn(
                name: "NumeClient",
                table: "Programare",
                newName: "NumePrenumeClient");

            migrationBuilder.RenameColumn(
                name: "GreutatePisica",
                table: "Programare",
                newName: "TipServiciuId");

            migrationBuilder.AlterColumn<string>(
                name: "Observatii",
                table: "TipHrana",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TipHranaId",
                table: "Programare",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observatii",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Programare",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Ora",
                table: "Programare",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TipCameraId",
                table: "Programare",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Recenzie",
                columns: table => new
                {
                    RecenzieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Scor = table.Column<int>(type: "int", nullable: false),
                    Comentariu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeAutor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzie", x => x.RecenzieId);
                });

            migrationBuilder.CreateTable(
                name: "TipServiciu",
                columns: table => new
                {
                    TipServiciuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denumire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Informatii = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pret = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipServiciu", x => x.TipServiciuId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Programare_TipCameraId",
                table: "Programare",
                column: "TipCameraId");

            migrationBuilder.CreateIndex(
                name: "IX_Programare_TipServiciuId",
                table: "Programare",
                column: "TipServiciuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_TipCamera_TipCameraId",
                table: "Programare",
                column: "TipCameraId",
                principalTable: "TipCamera",
                principalColumn: "TipCameraId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_TipHrana_TipHranaId",
                table: "Programare",
                column: "TipHranaId",
                principalTable: "TipHrana",
                principalColumn: "TipHranaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_TipServiciu_TipServiciuId",
                table: "Programare",
                column: "TipServiciuId",
                principalTable: "TipServiciu",
                principalColumn: "TipServiciuId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programare_TipCamera_TipCameraId",
                table: "Programare");

            migrationBuilder.DropForeignKey(
                name: "FK_Programare_TipHrana_TipHranaId",
                table: "Programare");

            migrationBuilder.DropForeignKey(
                name: "FK_Programare_TipServiciu_TipServiciuId",
                table: "Programare");

            migrationBuilder.DropTable(
                name: "Recenzie");

            migrationBuilder.DropTable(
                name: "TipServiciu");

            migrationBuilder.DropIndex(
                name: "IX_Programare_TipCameraId",
                table: "Programare");

            migrationBuilder.DropIndex(
                name: "IX_Programare_TipServiciuId",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "Ora",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "TipCameraId",
                table: "Programare");

            migrationBuilder.RenameColumn(
                name: "TipServiciuId",
                table: "Programare",
                newName: "GreutatePisica");

            migrationBuilder.RenameColumn(
                name: "NumePrenumeClient",
                table: "Programare",
                newName: "NumeClient");

            migrationBuilder.AlterColumn<string>(
                name: "Observatii",
                table: "TipHrana",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipHranaId",
                table: "Programare",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Observatii",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CameraId",
                table: "Programare",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CantitateHrana",
                table: "Programare",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "DataIesire",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DataIntrare",
                table: "Programare",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Programare_CameraId",
                table: "Programare",
                column: "CameraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Camera_CameraId",
                table: "Programare",
                column: "CameraId",
                principalTable: "Camera",
                principalColumn: "CameraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_TipHrana_TipHranaId",
                table: "Programare",
                column: "TipHranaId",
                principalTable: "TipHrana",
                principalColumn: "TipHranaId");
        }
    }
}
