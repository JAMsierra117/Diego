using Microsoft.EntityFrameworkCore.Migrations;

namespace Diego.Migrations
{
    public partial class ProductoCambioTablaName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Clasificaciones_ID_Clasificacion",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "Productos");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_ID_Clasificacion",
                table: "Productos",
                newName: "IX_Productos_ID_Clasificacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "ID_Producto");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Clasificaciones_ID_Clasificacion",
                table: "Productos",
                column: "ID_Clasificacion",
                principalTable: "Clasificaciones",
                principalColumn: "ID_Clasificacion",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Clasificaciones_ID_Clasificacion",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "Producto");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_ID_Clasificacion",
                table: "Producto",
                newName: "IX_Producto_ID_Clasificacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "ID_Producto");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Clasificaciones_ID_Clasificacion",
                table: "Producto",
                column: "ID_Clasificacion",
                principalTable: "Clasificaciones",
                principalColumn: "ID_Clasificacion",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
