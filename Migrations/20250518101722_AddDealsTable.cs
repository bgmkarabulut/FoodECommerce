using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodECommerce.Migrations
{
    /// <inheritdoc />
    public partial class AddDealsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deals",
                columns: table => new
                {
                    restaurant_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deals", x => x.restaurant_id);
                });

            migrationBuilder.InsertData(
                table: "Deals",
                columns: new[] { "restaurant_id", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Yaz aylarına özel .", "images/deals/dondurmalı.png", "Dondurma" },
                    { 2, "Dörtlü Big King + Coca-Cola", "images/deals/dörtlüdeal.png", "Menü 4 Big King" },
                    { 3, "TavukBurger menü ^KöfteBurger menü.", "images/deals/ikilideal.png", "Friends Menü" },
                    { 4, "RodeoBurger menü + Onion Fries.", "images/deals/rodeodeal.png", "Rodeoo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deals");
        }
    }
}
