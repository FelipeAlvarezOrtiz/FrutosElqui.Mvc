using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrutosElqui.Persistencia.Migrations
{
    public partial class Cotizaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courriers",
                columns: table => new
                {
                    IdCourrier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCourrier = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courriers", x => x.IdCourrier);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCotizaciones",
                columns: table => new
                {
                    IdEstadoCotizacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEstadoCotizacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCotizaciones", x => x.IdEstadoCotizacion);
                });

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    IdSucursal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreSucursal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Calle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ComunaIdComuna = table.Column<int>(type: "int", nullable: true),
                    RegionIdRegion = table.Column<int>(type: "int", nullable: true),
                    NumeroTelefonico = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    JefeSucursal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TipoSucursalIdTipoSucursal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.IdSucursal);
                    table.ForeignKey(
                        name: "FK_Sucursales_Comunas_ComunaIdComuna",
                        column: x => x.ComunaIdComuna,
                        principalTable: "Comunas",
                        principalColumn: "IdComuna",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sucursales_Regiones_RegionIdRegion",
                        column: x => x.RegionIdRegion,
                        principalTable: "Regiones",
                        principalColumn: "IdRegion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sucursales_TipoSucursales_TipoSucursalIdTipoSucursal",
                        column: x => x.TipoSucursalIdTipoSucursal,
                        principalTable: "TipoSucursales",
                        principalColumn: "IdTipoSucursal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesDeCotizaciones",
                columns: table => new
                {
                    IdDetalleCotizacion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductoIdProducto = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    SucursalOrigenIdSucursal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesDeCotizaciones", x => x.IdDetalleCotizacion);
                    table.ForeignKey(
                        name: "FK_DetallesDeCotizaciones_Productos_ProductoIdProducto",
                        column: x => x.ProductoIdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesDeCotizaciones_Sucursales_SucursalOrigenIdSucursal",
                        column: x => x.SucursalOrigenIdSucursal,
                        principalTable: "Sucursales",
                        principalColumn: "IdSucursal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDeCotizaciones_ProductoIdProducto",
                table: "DetallesDeCotizaciones",
                column: "ProductoIdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDeCotizaciones_SucursalOrigenIdSucursal",
                table: "DetallesDeCotizaciones",
                column: "SucursalOrigenIdSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_ComunaIdComuna",
                table: "Sucursales",
                column: "ComunaIdComuna");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_RegionIdRegion",
                table: "Sucursales",
                column: "RegionIdRegion");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_TipoSucursalIdTipoSucursal",
                table: "Sucursales",
                column: "TipoSucursalIdTipoSucursal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courriers");

            migrationBuilder.DropTable(
                name: "DetallesDeCotizaciones");

            migrationBuilder.DropTable(
                name: "EstadoCotizaciones");

            migrationBuilder.DropTable(
                name: "Sucursales");
        }
    }
}
