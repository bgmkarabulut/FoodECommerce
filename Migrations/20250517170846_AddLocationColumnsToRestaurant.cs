using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodECommerce.Migrations
{
    /// <inheritdoc />
    public partial class AddLocationColumnsToRestaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Restaurants",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "Restaurants",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Restaurants",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "images/products/ballımustrad.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "images/products/cookie.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Restaurants");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "images/products/ballmustrad.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "images/products/kurabiye.png");
        }
    }
}
