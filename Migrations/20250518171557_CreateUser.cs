using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodECommerce.Migrations
{
    /// <inheritdoc />
    public partial class CreateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "restaurant_id",
                keyValue: 1,
                column: "ImageUrl",
                value: "images/deals/dondurmadeal.png");

            migrationBuilder.InsertData(
                table: "Deals",
                columns: new[] { "restaurant_id", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 5, "Big King + King Chicken", "images/deals/kralikili.png", "King 2" },
                    { 6, "3 Whopper menü + Coca-Cola", "images/deals/üçlüwhopper.png", "Tripple Whopper" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Deals",
                keyColumn: "restaurant_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Deals",
                keyColumn: "restaurant_id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Deals",
                keyColumn: "restaurant_id",
                keyValue: 1,
                column: "ImageUrl",
                value: "images/deals/dondurmalı.png");
        }
    }
}
