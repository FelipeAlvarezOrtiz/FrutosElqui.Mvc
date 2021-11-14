using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrutosElqui.Persistencia.Migrations
{
    public partial class Ventas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    IdVenta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SucursalIdSucursal = table.Column<int>(type: "int", nullable: true),
                    NombreUsuarioVenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RutUsuarioVenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaVenta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoPagoIdTipoPago = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Descuento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.IdVenta);
                    table.ForeignKey(
                        name: "FK_Ventas_Sucursales_SucursalIdSucursal",
                        column: x => x.SucursalIdSucursal,
                        principalTable: "Sucursales",
                        principalColumn: "IdSucursal",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ventas_TipoPagos_TipoPagoIdTipoPago",
                        column: x => x.TipoPagoIdTipoPago,
                        principalTable: "TipoPagos",
                        principalColumn: "IdTipoPago",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesVentas",
                columns: table => new
                {
                    IdDetalle = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreProducto = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    IdProveedor = table.Column<int>(type: "int", nullable: false),
                    NombreProveedor = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CantidadProducto = table.Column<int>(type: "int", nullable: false),
                    TotalProducto = table.Column<int>(type: "int", nullable: false),
                    VentaIdVenta = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesVentas", x => x.IdDetalle);
                    table.ForeignKey(
                        name: "FK_DetallesVentas_Ventas_VentaIdVenta",
                        column: x => x.VentaIdVenta,
                        principalTable: "Ventas",
                        principalColumn: "IdVenta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OfertasVentas",
                columns: table => new
                {
                    IdOfertasVenta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdOferta = table.Column<int>(type: "int", nullable: false),
                    NombreOferta = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CantidadOferta = table.Column<int>(type: "int", nullable: false),
                    VentaIdVenta = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfertasVentas", x => x.IdOfertasVenta);
                    table.ForeignKey(
                        name: "FK_OfertasVentas_Ventas_VentaIdVenta",
                        column: x => x.VentaIdVenta,
                        principalTable: "Ventas",
                        principalColumn: "IdVenta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesVentas_VentaIdVenta",
                table: "DetallesVentas",
                column: "VentaIdVenta");

            migrationBuilder.CreateIndex(
                name: "IX_OfertasVentas_VentaIdVenta",
                table: "OfertasVentas",
                column: "VentaIdVenta");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_SucursalIdSucursal",
                table: "Ventas",
                column: "SucursalIdSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_TipoPagoIdTipoPago",
                table: "Ventas",
                column: "TipoPagoIdTipoPago");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesVentas");

            migrationBuilder.DropTable(
                name: "OfertasVentas");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
