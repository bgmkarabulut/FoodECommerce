using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodECommerce.Migrations
{
    /// <inheritdoc />
    public partial class RemoveImageAndDescriptionFromRestaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "image_url",
                table: "Restaurants");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Restaurants",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image_url",
                table: "Restaurants",
                type: "text",
                nullable: true);
        }
    }
}
