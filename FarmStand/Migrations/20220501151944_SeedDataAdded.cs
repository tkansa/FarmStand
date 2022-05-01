using Microsoft.EntityFrameworkCore.Migrations;

namespace FarmStand.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Sweet Fruits", "Fruit" },
                    { 2, "Vegetables ", "Root Vegetables" },
                    { 3, "Savory Fruits", "Seeded Vegetables" },
                    { 4, "Underground Produce", "Root Vegetables" },
                    { 5, "Aromatic Leaves", "Herbs" }
                });

            migrationBuilder.InsertData(
                table: "Produce",
                columns: new[] { "ProduceId", "CategoryId", "ImageUrl", "IsProduceOfTheWeek", "Name", "Price" },
                values: new object[] { 1, 1, "", false, "Strawberries", 4.99m });

            migrationBuilder.InsertData(
                table: "Produce",
                columns: new[] { "ProduceId", "CategoryId", "ImageUrl", "IsProduceOfTheWeek", "Name", "Price" },
                values: new object[] { 2, 2, "", false, "Onions", 1.99m });

            migrationBuilder.InsertData(
                table: "Produce",
                columns: new[] { "ProduceId", "CategoryId", "ImageUrl", "IsProduceOfTheWeek", "Name", "Price" },
                values: new object[] { 3, 3, "", true, "Cucumbers", 3.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produce",
                keyColumn: "ProduceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produce",
                keyColumn: "ProduceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produce",
                keyColumn: "ProduceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
