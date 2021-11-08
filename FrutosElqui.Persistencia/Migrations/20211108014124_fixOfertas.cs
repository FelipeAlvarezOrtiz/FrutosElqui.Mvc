using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrutosElqui.Persistencia.Migrations
{
    public partial class fixOfertas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesOfertas");

            migrationBuilder.CreateTable(
                name: "DetallesDeOfertas",
                columns: table => new
                {
                    GuidDetalle = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductoIdProducto = table.Column<int>(type: "int", nullable: true),
                    CantidadProducto = table.Column<int>(type: "int", nullable: false),
                    OfertaGuidOferta = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesDeOfertas", x => x.GuidDetalle);
                    table.ForeignKey(
                        name: "FK_DetallesDeOfertas_Ofertas_OfertaGuidOferta",
                        column: x => x.OfertaGuidOferta,
                        principalTable: "Ofertas",
                        principalColumn: "GuidOferta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesDeOfertas_Productos_ProductoIdProducto",
                        column: x => x.ProductoIdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDeOfertas_OfertaGuidOferta",
                table: "DetallesDeOfertas",
                column: "OfertaGuidOferta");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDeOfertas_ProductoIdProducto",
                table: "DetallesDeOfertas",
                column: "ProductoIdProducto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesDeOfertas");

            migrationBuilder.CreateTable(
                name: "DetallesOfertas",
                columns: table => new
                {
                    GuidDetalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadProducto = table.Column<int>(type: "int", nullable: false),
                    OfertaGuidOferta = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductoIdProducto = table.Column<int>(type: "int", nullable: true)
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
    }
}
