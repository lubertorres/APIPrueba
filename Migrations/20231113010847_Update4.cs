using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiPrueba.Migrations
{
    /// <inheritdoc />
    public partial class Update4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_UserID1",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_UserID1",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "ShoppingCarts");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartID",
                table: "Items",
                column: "ShoppingCartID",
                principalTable: "ShoppingCarts",
                principalColumn: "ShoppingCardID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartID",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "UserID1",
                table: "ShoppingCarts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserID1",
                table: "ShoppingCarts",
                column: "UserID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ShoppingCarts_ShoppingCartID",
                table: "Items",
                column: "ShoppingCartID",
                principalTable: "ShoppingCarts",
                principalColumn: "ShoppingCardID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Users_UserID1",
                table: "ShoppingCarts",
                column: "UserID1",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
