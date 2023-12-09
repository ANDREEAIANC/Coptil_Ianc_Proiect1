using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coptil_Ianc_Proiect1.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Camera_TipCamera_TipCameraId",
                table: "Camera");

            migrationBuilder.AlterColumn<int>(
                name: "TipCameraId",
                table: "Camera",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Camera_TipCamera_TipCameraId",
                table: "Camera",
                column: "TipCameraId",
                principalTable: "TipCamera",
                principalColumn: "TipCameraId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Camera_TipCamera_TipCameraId",
                table: "Camera");

            migrationBuilder.AlterColumn<int>(
                name: "TipCameraId",
                table: "Camera",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Camera_TipCamera_TipCameraId",
                table: "Camera",
                column: "TipCameraId",
                principalTable: "TipCamera",
                principalColumn: "TipCameraId");
        }
    }
}
