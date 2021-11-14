using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrutosElqui.Persistencia.Migrations
{
    public partial class FixOfertaDetalle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdOferta",
                table: "OfertasVentas");

            migrationBuilder.AddColumn<Guid>(
                name: "GuidOferta",
                table: "OfertasVentas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuidOferta",
                table: "OfertasVentas");

            migrationBuilder.AddColumn<int>(
                name: "IdOferta",
                table: "OfertasVentas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
