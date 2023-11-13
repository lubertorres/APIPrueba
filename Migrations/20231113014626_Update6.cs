using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiPrueba.Migrations
{
    /// <inheritdoc />
    public partial class Update6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_UserID",
                table: "ShoppingCarts");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartID",
                table: "Items",
                column: "ShoppingCartID",
                principalTable: "ShoppingCarts",
                principalColumn: "ShoppingCardID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Users_UserID",
                table: "ShoppingCarts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_UserID",
                table: "ShoppingCarts");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartID",
                table: "Items",
                column: "ShoppingCartID",
                principalTable: "ShoppingCarts",
                principalColumn: "ShoppingCardID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Users_UserID",
                table: "ShoppingCarts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");
        }
    }
}
