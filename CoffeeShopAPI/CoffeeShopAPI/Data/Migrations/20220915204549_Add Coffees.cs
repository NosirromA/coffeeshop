using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShopAPI.Data.Migrations
{
    public partial class AddCoffees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoffeeTypes",
                columns: new[] { "Id", "Description", "DiscountId", "Name", "Price", "ReceiptId", "Sku", "Stock" },
                values: new object[] { 1, "Coffee with milk", null, "Latte", 4.5, null, 45, 10 });

            migrationBuilder.InsertData(
                table: "CoffeeTypes",
                columns: new[] { "Id", "Description", "DiscountId", "Name", "Price", "ReceiptId", "Sku", "Stock" },
                values: new object[] { 2, "A cappuccino is an espresso-based coffee drink that originated in Italy", null, "Cappuccino", 2.5, null, 46, 1 });

            migrationBuilder.InsertData(
                table: "CoffeeTypes",
                columns: new[] { "Id", "Description", "DiscountId", "Name", "Price", "ReceiptId", "Sku", "Stock" },
                values: new object[] { 3, "If you call it an Expresso you get barred for life", null, "Espresso", 13.99, null, 99, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoffeeTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoffeeTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CoffeeTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
