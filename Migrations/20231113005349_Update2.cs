using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiPrueba.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartEntityShoppingCardID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ShoppingCartEntityShoppingCardID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ShoppingCartEntityShoppingCardID",
                table: "Items");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ShoppingCartID",
                table: "Items",
                column: "ShoppingCartID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartID",
                table: "Items",
                column: "ShoppingCartID",
                principalTable: "ShoppingCarts",
                principalColumn: "ShoppingCardID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartID",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ShoppingCartID",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartEntityShoppingCardID",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_ShoppingCartEntityShoppingCardID",
                table: "Items",
                column: "ShoppingCartEntityShoppingCardID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartEntityShoppingCardID",
                table: "Items",
                column: "ShoppingCartEntityShoppingCardID",
                principalTable: "ShoppingCarts",
                principalColumn: "ShoppingCardID");
        }
    }
}
