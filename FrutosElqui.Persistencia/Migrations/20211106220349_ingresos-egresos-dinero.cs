using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrutosElqui.Persistencia.Migrations
{
    public partial class ingresosegresosdinero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EgresosDineros",
                columns: table => new
                {
                    IdEgreso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaEgreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CantidadEgresada = table.Column<int>(type: "int", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SucursalOrigenIdSucursal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgresosDineros", x => x.IdEgreso);
                    table.ForeignKey(
                        name: "FK_EgresosDineros_Sucursales_SucursalOrigenIdSucursal",
                        column: x => x.SucursalOrigenIdSucursal,
                        principalTable: "Sucursales",
                        principalColumn: "IdSucursal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IngresosDineros",
                columns: table => new
                {
                    IdIngreso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CantidadIngresado = table.Column<int>(type: "int", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SucursalOrigenIdSucursal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresosDineros", x => x.IdIngreso);
                    table.ForeignKey(
                        name: "FK_IngresosDineros_Sucursales_SucursalOrigenIdSucursal",
                        column: x => x.SucursalOrigenIdSucursal,
                        principalTable: "Sucursales",
                        principalColumn: "IdSucursal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EgresosDineros_SucursalOrigenIdSucursal",
                table: "EgresosDineros",
                column: "SucursalOrigenIdSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_IngresosDineros_SucursalOrigenIdSucursal",
                table: "IngresosDineros",
                column: "SucursalOrigenIdSucursal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EgresosDineros");

            migrationBuilder.DropTable(
                name: "IngresosDineros");
        }
    }
}
