using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shelter.Migrations
{
    public partial class DogPark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Breed = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "varchar(10) CHARACTER SET utf8mb4", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "DogPark",
                columns: table => new
                {
                    DogParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogPark", x => x.DogParkId);
                });

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

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Breed = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "varchar(10) CHARACTER SET utf8mb4", maxLength: 10, nullable: false),
                    DogParkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogId);
                    table.ForeignKey(
                        name: "FK_Dogs_DogPark_DogParkId",
                        column: x => x.DogParkId,
                        principalTable: "DogPark",
                        principalColumn: "DogParkId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "DogParkId", "Gender", "Name" },
                values: new object[,]
                {
                    { 6, 4, "Bread dog", 0, "Bread", "Baguette" },
                    { 5, 4, "Dog", 0, "Dog", "Dog" },
                    { 4, 16, "Got it goin on", 0, "Mom", "Stacy" },
                    { 1, 4, "Hot Dog", 0, "Male", "Pickles" },
                    { 2, 5, "Cold Dog", 0, "Male", "Jeremy" },
                    { 3, 10, "Long Haired Pug", 0, "Male", "Fred" }
                });

            migrationBuilder.InsertData(
                table: "Monkeys",
                columns: new[] { "MonkeyId", "Age", "Gender", "Name" },
                values: new object[,]
                {
                    { 3, 33, "Male", "Connor McMonkey" },
                    { 1, 30, "Female", "Koko" },
                    { 2, 45, "Male", "Bilbo Baggins" },
                    { 4, 22, "Female", "Izzy Booboo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_DogParkId",
                table: "Dogs",
                column: "DogParkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");

            migrationBuilder.DropTable(
                name: "Monkeys");

            migrationBuilder.DropTable(
                name: "DogPark");
        }
    }
}
