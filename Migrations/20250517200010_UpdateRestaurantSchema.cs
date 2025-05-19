using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodECommerce.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRestaurantSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 2,
                columns: new[] { "City", "Latitude", "Longitude", "Name", "Rating" },
                values: new object[] { "İstanbul", "41.0438", "29.0094", "Food Express Beşiktaş", 0m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 3,
                columns: new[] { "City", "Latitude", "Longitude", "Name", "Rating" },
                values: new object[] { "İstanbul", "40.9760", "28.8570", "Food Express Bakırköy", 0m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 4,
                columns: new[] { "City", "Latitude", "Longitude", "Name", "Rating" },
                values: new object[] { "İstanbul", "41.0165", "29.1241", "Food Express Ümraniye", 0m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 5,
                columns: new[] { "City", "Latitude", "Longitude", "Rating" },
                values: new object[] { "Ankara", "39.9334", "32.8597", 4.5m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 6,
                columns: new[] { "City", "Latitude", "Longitude", "Name", "Rating" },
                values: new object[] { "Ankara", "39.9208", "32.8541", "Food Express Kızılay", 0m });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "restaurant_id", "City", "Latitude", "Longitude", "Name", "Rating" },
                values: new object[,]
                {
                    { 7, "Ankara", "39.9016", "32.8597", "Food Express Çankaya", 0m },
                    { 8, "Ankara", "40.0071", "32.8663", "Food Express Keçiören", 0m },
                    { 9, "İzmir", "38.4192", "27.1287", "Food Express Alsancak", 4.8m },
                    { 10, "Bursa", "40.1826", "29.0668", "Food Express Özlüce", 4.7m },
                    { 11, "Antalya", "36.8969", "30.7133", "Food Express Antalya", 4.6m },
                    { 12, "Adana", "37.0017", "35.3213", "Food Express Adana", 4.9m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 2,
                columns: new[] { "City", "Latitude", "Longitude", "Name", "Rating" },
                values: new object[] { "Ankara", "39.9334", "32.8597", "Food Express", 4.5m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 3,
                columns: new[] { "City", "Latitude", "Longitude", "Name", "Rating" },
                values: new object[] { "İzmir", "38.4192", "27.1287", "Food Express", 4.8m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 4,
                columns: new[] { "City", "Latitude", "Longitude", "Name", "Rating" },
                values: new object[] { "Bursa", "40.1826", "29.0668", "Food Express", 4.7m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 5,
                columns: new[] { "City", "Latitude", "Longitude", "Rating" },
                values: new object[] { "Antalya", "36.8969", "30.7133", 4.6m });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 6,
                columns: new[] { "City", "Latitude", "Longitude", "Name", "Rating" },
                values: new object[] { "Adana", "37.0017", "35.3213", "Food Express", 4.9m });
        }
    }
}
