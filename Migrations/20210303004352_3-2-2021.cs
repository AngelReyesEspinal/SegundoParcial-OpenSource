using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaDeCompras.Migrations
{
    public partial class _322021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartamentoId",
                table: "OrdenesDeCompra",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProveedorId",
                table: "OrdenesDeCompra",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesDeCompra_DepartamentoId",
                table: "OrdenesDeCompra",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesDeCompra_ProveedorId",
                table: "OrdenesDeCompra",
                column: "ProveedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenesDeCompra_Departamentos_DepartamentoId",
                table: "OrdenesDeCompra",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenesDeCompra_Proveedores_ProveedorId",
                table: "OrdenesDeCompra",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdenesDeCompra_Departamentos_DepartamentoId",
                table: "OrdenesDeCompra");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdenesDeCompra_Proveedores_ProveedorId",
                table: "OrdenesDeCompra");

            migrationBuilder.DropIndex(
                name: "IX_OrdenesDeCompra_DepartamentoId",
                table: "OrdenesDeCompra");

            migrationBuilder.DropIndex(
                name: "IX_OrdenesDeCompra_ProveedorId",
                table: "OrdenesDeCompra");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "OrdenesDeCompra");

            migrationBuilder.DropColumn(
                name: "ProveedorId",
                table: "OrdenesDeCompra");
        }
    }
}
