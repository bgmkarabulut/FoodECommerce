using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodECommerce.Migrations
{
    /// <inheritdoc />
    public partial class SeedRestaurants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "restaurant_id", "City", "Latitude", "Longitude", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "İstanbul", "41.0082", "28.9784", "Food Express", 5.0m },
                    { 2, "Ankara", "39.9334", "32.8597", "Food Express", 4.5m },
                    { 3, "İzmir", "38.4192", "27.1287", "Food Express", 4.8m },
                    { 4, "Bursa", "40.1826", "29.0668", "Food Express", 4.7m },
                    { 5, "Antalya", "36.8969", "30.7133", "Food Express", 4.6m },
                    { 6, "Adana", "37.0017", "35.3213", "Food Express", 4.9m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 6);
        }
    }
}
