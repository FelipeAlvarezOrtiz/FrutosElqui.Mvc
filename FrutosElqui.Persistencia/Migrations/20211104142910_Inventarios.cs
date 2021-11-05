using Microsoft.EntityFrameworkCore.Migrations;

namespace FrutosElqui.Persistencia.Migrations
{
    public partial class Inventarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    IdDetalleInventario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SucursalIdSucursal = table.Column<int>(type: "int", nullable: true),
                    ProductoIdProducto = table.Column<int>(type: "int", nullable: true),
                    CantidadDisponible = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.IdDetalleInventario);
                    table.ForeignKey(
                        name: "FK_Inventarios_Productos_ProductoIdProducto",
                        column: x => x.ProductoIdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventarios_Sucursales_SucursalIdSucursal",
                        column: x => x.SucursalIdSucursal,
                        principalTable: "Sucursales",
                        principalColumn: "IdSucursal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_ProductoIdProducto",
                table: "Inventarios",
                column: "ProductoIdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_SucursalIdSucursal",
                table: "Inventarios",
                column: "SucursalIdSucursal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventarios");
        }
    }
}
