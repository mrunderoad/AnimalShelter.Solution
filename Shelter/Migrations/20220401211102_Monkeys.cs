using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shelter.Migrations
{
    public partial class Monkeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monkeys",
                columns: table => new
                {
                    MonkeyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "varchar(10) CHARACTER SET utf8mb4", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monkeys", x => x.MonkeyId);
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "Gender", "Name" },
                values: new object[] { 7, 4, "Rad dog", "Rad", "Rad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monkeys");

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 7);
        }
    }
}
