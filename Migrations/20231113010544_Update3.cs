using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiPrueba.Migrations
{
    /// <inheritdoc />
    public partial class Update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_UserID",
                table: "ShoppingCarts");

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
                name: "FK_ShoppingCarts_Users_UserID",
                table: "ShoppingCarts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Users_UserID1",
                table: "ShoppingCarts",
                column: "UserID1",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_UserID",
                table: "ShoppingCarts");

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
                name: "FK_ShoppingCarts_Users_UserID",
                table: "ShoppingCarts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
