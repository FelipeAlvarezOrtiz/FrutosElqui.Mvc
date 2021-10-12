using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrutosElqui.Persistencia.Migrations
{
    public partial class addsCores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentosTributarios",
                columns: table => new
                {
                    IdDte = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDte = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentosTributarios", x => x.IdDte);
                });

            migrationBuilder.CreateTable(
                name: "Giros",
                columns: table => new
                {
                    IdGiro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreGiro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IdGiroSii = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giros", x => x.IdGiro);
                });

            migrationBuilder.CreateTable(
                name: "Medidas",
                columns: table => new
                {
                    IdMedida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMedida = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medidas", x => x.IdMedida);
                });

            migrationBuilder.CreateTable(
                name: "Regiones",
                columns: table => new
                {
                    IdRegion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreRegion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiones", x => x.IdRegion);
                });

            migrationBuilder.CreateTable(
                name: "Sabores",
                columns: table => new
                {
                    IdSabor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreSabor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sabores", x => x.IdSabor);
                });

            migrationBuilder.CreateTable(
                name: "Sectores",
                columns: table => new
                {
                    IdSector = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreSector = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectores", x => x.IdSector);
                });

            migrationBuilder.CreateTable(
                name: "TipoCuentas",
                columns: table => new
                {
                    IdTipoCuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoCuenta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCuentas", x => x.IdTipoCuenta);
                });

            migrationBuilder.CreateTable(
                name: "TipoPagos",
                columns: table => new
                {
                    IdTipoPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoPago = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPagos", x => x.IdTipoPago);
                });

            migrationBuilder.CreateTable(
                name: "TipoSucursales",
                columns: table => new
                {
                    IdTipoSucursal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoSucursal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSucursales", x => x.IdTipoSucursal);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCliente = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    DireccionCliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RutCliente = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    EsMayorista = table.Column<bool>(type: "bit", nullable: false),
                    SectorClienteIdSector = table.Column<int>(type: "int", nullable: true),
                    ComunaClienteIdComuna = table.Column<int>(type: "int", nullable: true),
                    RegionClienteIdRegion = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Clientes_Comunas_ComunaClienteIdComuna",
                        column: x => x.ComunaClienteIdComuna,
                        principalTable: "Comunas",
                        principalColumn: "IdComuna",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_Regiones_RegionClienteIdRegion",
                        column: x => x.RegionClienteIdRegion,
                        principalTable: "Regiones",
                        principalColumn: "IdRegion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_Sectores_SectorClienteIdSector",
                        column: x => x.SectorClienteIdSector,
                        principalTable: "Sectores",
                        principalColumn: "IdSector",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProveedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DireccionProveedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RutProveedor = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    DiaFacturacion = table.Column<int>(type: "int", nullable: true),
                    BancoProveedorIdBanco = table.Column<int>(type: "int", nullable: true),
                    TipoCuentaProveedorIdTipoCuenta = table.Column<int>(type: "int", nullable: true),
                    TipoPagoProveedorIdTipoPago = table.Column<int>(type: "int", nullable: true),
                    NumeroCuenta = table.Column<int>(type: "int", nullable: false),
                    GiroProveedorIdGiro = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.IdProveedor);
                    table.ForeignKey(
                        name: "FK_Proveedores_Bancos_BancoProveedorIdBanco",
                        column: x => x.BancoProveedorIdBanco,
                        principalTable: "Bancos",
                        principalColumn: "IdBanco",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proveedores_Giros_GiroProveedorIdGiro",
                        column: x => x.GiroProveedorIdGiro,
                        principalTable: "Giros",
                        principalColumn: "IdGiro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proveedores_TipoCuentas_TipoCuentaProveedorIdTipoCuenta",
                        column: x => x.TipoCuentaProveedorIdTipoCuenta,
                        principalTable: "TipoCuentas",
                        principalColumn: "IdTipoCuenta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proveedores_TipoPagos_TipoPagoProveedorIdTipoPago",
                        column: x => x.TipoPagoProveedorIdTipoPago,
                        principalTable: "TipoPagos",
                        principalColumn: "IdTipoPago",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    DescripcionProducto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PrecioMayorista = table.Column<int>(type: "int", nullable: true),
                    PrecioTotal = table.Column<int>(type: "int", nullable: false),
                    Costo = table.Column<int>(type: "int", nullable: false),
                    FechaCreacionProducto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombreBusqueda = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SaborProductoIdSabor = table.Column<int>(type: "int", nullable: true),
                    CategoriaProductoIdCategoria = table.Column<int>(type: "int", nullable: true),
                    MedidaProductoIdMedida = table.Column<int>(type: "int", nullable: true),
                    ProveedorProductoIdProveedor = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_CategoriaProductoIdCategoria",
                        column: x => x.CategoriaProductoIdCategoria,
                        principalTable: "Categorias",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Medidas_MedidaProductoIdMedida",
                        column: x => x.MedidaProductoIdMedida,
                        principalTable: "Medidas",
                        principalColumn: "IdMedida",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Proveedores_ProveedorProductoIdProveedor",
                        column: x => x.ProveedorProductoIdProveedor,
                        principalTable: "Proveedores",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Productos_Sabores_SaborProductoIdSabor",
                        column: x => x.SaborProductoIdSabor,
                        principalTable: "Sabores",
                        principalColumn: "IdSabor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ComunaClienteIdComuna",
                table: "Clientes",
                column: "ComunaClienteIdComuna");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_RegionClienteIdRegion",
                table: "Clientes",
                column: "RegionClienteIdRegion");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_SectorClienteIdSector",
                table: "Clientes",
                column: "SectorClienteIdSector");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriaProductoIdCategoria",
                table: "Productos",
                column: "CategoriaProductoIdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_MedidaProductoIdMedida",
                table: "Productos",
                column: "MedidaProductoIdMedida");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ProveedorProductoIdProveedor",
                table: "Productos",
                column: "ProveedorProductoIdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_SaborProductoIdSabor",
                table: "Productos",
                column: "SaborProductoIdSabor");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_BancoProveedorIdBanco",
                table: "Proveedores",
                column: "BancoProveedorIdBanco");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_GiroProveedorIdGiro",
                table: "Proveedores",
                column: "GiroProveedorIdGiro");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_TipoCuentaProveedorIdTipoCuenta",
                table: "Proveedores",
                column: "TipoCuentaProveedorIdTipoCuenta");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_TipoPagoProveedorIdTipoPago",
                table: "Proveedores",
                column: "TipoPagoProveedorIdTipoPago");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "DocumentosTributarios");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "TipoSucursales");

            migrationBuilder.DropTable(
                name: "Regiones");

            migrationBuilder.DropTable(
                name: "Sectores");

            migrationBuilder.DropTable(
                name: "Medidas");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Sabores");

            migrationBuilder.DropTable(
                name: "Giros");

            migrationBuilder.DropTable(
                name: "TipoCuentas");

            migrationBuilder.DropTable(
                name: "TipoPagos");
        }
    }
}
