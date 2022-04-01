using Microsoft.EntityFrameworkCore.Migrations;

namespace Shelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Breed", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, 2, "Red One", "Male", "Sr.Waffles" },
                    { 2, 5, "Pink One", "Male", "Senior Meowmeow" },
                    { 3, 12, "Black Cat", "Male", "Frank the Tank" },
                    { 4, 7, "White Cat", "Male", "Henry" },
                    { 5, 4, "I dont know cat breeds", "Female", "Cat" },
                    { 6, 5, "CodeCat", "Male", "Epicat" },
                    { 7, 100, "FatCat", "Male", "Bill" },
                    { 8, 1, "KittyCat", "Male", "Phil" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 8);
        }
    }
}
