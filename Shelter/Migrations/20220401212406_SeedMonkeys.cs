using Microsoft.EntityFrameworkCore.Migrations;

namespace Shelter.Migrations
{
    public partial class SeedMonkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "Monkeys",
                columns: new[] { "MonkeyId", "Age", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, 30, "Female", "Koko" },
                    { 2, 45, "Male", "Bilbo Baggins" },
                    { 3, 33, "Male", "Connor McMonkey" },
                    { 4, 22, "Female", "Izzy Booboo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Monkeys",
                keyColumn: "MonkeyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Monkeys",
                keyColumn: "MonkeyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Monkeys",
                keyColumn: "MonkeyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Monkeys",
                keyColumn: "MonkeyId",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "Gender", "Name" },
                values: new object[] { 7, 4, "Rad dog", "Rad", "Rad" });
        }
    }
}
