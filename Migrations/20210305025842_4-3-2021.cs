using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaDeCompras.Migrations
{
    public partial class _432021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "UnidadesDeMedida",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Articulos",
                newName: "Nombre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "UnidadesDeMedida",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Articulos",
                newName: "Descripcion");
        }
    }
}
