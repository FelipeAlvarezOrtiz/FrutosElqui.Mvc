using Microsoft.EntityFrameworkCore.Migrations;

namespace FrutosElqui.Persistencia.Migrations
{
    public partial class CamposUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComunaUsuarioIdComuna",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegionUsuarioIdRegion",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ComunaUsuarioIdComuna",
                table: "AspNetUsers",
                column: "ComunaUsuarioIdComuna");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RegionUsuarioIdRegion",
                table: "AspNetUsers",
                column: "RegionUsuarioIdRegion");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Comunas_ComunaUsuarioIdComuna",
                table: "AspNetUsers",
                column: "ComunaUsuarioIdComuna",
                principalTable: "Comunas",
                principalColumn: "IdComuna",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Regiones_RegionUsuarioIdRegion",
                table: "AspNetUsers",
                column: "RegionUsuarioIdRegion",
                principalTable: "Regiones",
                principalColumn: "IdRegion",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Comunas_ComunaUsuarioIdComuna",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Regiones_RegionUsuarioIdRegion",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ComunaUsuarioIdComuna",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RegionUsuarioIdRegion",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ComunaUsuarioIdComuna",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RegionUsuarioIdRegion",
                table: "AspNetUsers");
        }
    }
}
