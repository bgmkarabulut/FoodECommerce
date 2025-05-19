using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodECommerce.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Lezzetli tavuk burger menüsü.", "images/products/chickenroyalemenü.png", "Chicken Royale Menü", 250m },
                    { 2, 1, "Lezzetli tavuk burger menüsü.", "images/products/tavukburgermenü.png", "Tavuk Burger Menü", 215m },
                    { 3, 1, "Baharatlı menü seçeneği.", "images/products/spicymenü.png", "Spicy Menü", 230m },
                    { 4, 2, "Klasik burger.", "images/products/whopper.png", "Whopper", 155m },
                    { 5, 2, "Barbekü soslu burger.", "images/products/rodeo.png", "Rodeo Burger", 135m },
                    { 6, 2, "Tavuk burger.", "images/products/tavuklu.png", "Tavuklu Burger", 120m },
                    { 7, 5, "Ballı hardal sos.", "images/products/ballmustrad.png", "Ball Mustard", 6m },
                    { 8, 5, "Klasik ketçap.", "images/products/ketçap.png", "Ketçap", 6m },
                    { 9, 5, "Klasik mayonez.", "images/products/mayonez.png", "Mayonez", 6m },
                    { 10, 3, "Soslu dondurma.", "images/products/sundae.png", "Sundae", 45m },
                    { 11, 3, "Kurabiye", "images/products/kurabiye.png", "Cookie", 45m },
                    { 12, 4, " Kola", "images/products/cocacola.png", "Coca-Cola", 40m },
                    { 13, 4, "Fanta", "images/products/fanta.png", "Fanta", 40m },
                    { 14, 4, "Sıcak çikolata", "images/products/sıcakçiko.png", "Hot Chocolate", 40m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
