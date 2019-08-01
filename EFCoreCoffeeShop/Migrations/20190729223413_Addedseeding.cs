using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreCoffeeShop.Migrations
{
    public partial class Addedseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Quantity", "UserInfoId" },
                values: new object[] { 1, "Hot Chocolate", 2.5, 10, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Quantity", "UserInfoId" },
                values: new object[] { 2, "Coffee", 1.5, 10, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Quantity", "UserInfoId" },
                values: new object[] { 3, "Latte", 3.5, 10, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);
        }
    }
}
