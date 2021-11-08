using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrutosElqui.Persistencia.Migrations
{
    public partial class Ofertas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ofertas",
                columns: table => new
                {
                    GuidOferta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrecioOferta = table.Column<int>(type: "int", nullable: false),
                    NombreOferta = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ofertas", x => x.GuidOferta);
                });

            migrationBuilder.CreateTable(
                name: "DetallesOfertas",
                columns: table => new
                {
                    GuidDetalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductoIdProducto = table.Column<int>(type: "int", nullable: true),
                    CantidadProducto = table.Column<int>(type: "int", nullable: false),
                    OfertaGuidOferta = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesOfertas", x => x.GuidDetalle);
                    table.ForeignKey(
                        name: "FK_DetallesOfertas_Ofertas_OfertaGuidOferta",
                        column: x => x.OfertaGuidOferta,
                        principalTable: "Ofertas",
                        principalColumn: "GuidOferta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesOfertas_Productos_ProductoIdProducto",
                        column: x => x.ProductoIdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesOfertas_OfertaGuidOferta",
                table: "DetallesOfertas",
                column: "OfertaGuidOferta");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesOfertas_ProductoIdProducto",
                table: "DetallesOfertas",
                column: "ProductoIdProducto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesOfertas");

            migrationBuilder.DropTable(
                name: "Ofertas");
        }
    }
}
