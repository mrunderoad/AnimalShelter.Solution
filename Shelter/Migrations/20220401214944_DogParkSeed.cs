using Microsoft.EntityFrameworkCore.Migrations;

namespace Shelter.Migrations
{
    public partial class DogParkSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_DogPark_DogParkId",
                table: "Dogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DogPark",
                table: "DogPark");

            migrationBuilder.RenameTable(
                name: "DogPark",
                newName: "DogParks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DogParks",
                table: "DogParks",
                column: "DogParkId");

            migrationBuilder.InsertData(
                table: "DogParks",
                columns: new[] { "DogParkId", "Name" },
                values: new object[] { 1, "Play Land" });

            migrationBuilder.InsertData(
                table: "DogParks",
                columns: new[] { "DogParkId", "Name" },
                values: new object[] { 2, "Dog Land" });

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1,
                column: "DogParkId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2,
                column: "DogParkId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3,
                column: "DogParkId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4,
                column: "DogParkId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5,
                column: "DogParkId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 6,
                column: "DogParkId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_DogParks_DogParkId",
                table: "Dogs",
                column: "DogParkId",
                principalTable: "DogParks",
                principalColumn: "DogParkId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_DogParks_DogParkId",
                table: "Dogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DogParks",
                table: "DogParks");

            migrationBuilder.DeleteData(
                table: "DogParks",
                keyColumn: "DogParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DogParks",
                keyColumn: "DogParkId",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "DogParks",
                newName: "DogPark");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DogPark",
                table: "DogPark",
                column: "DogParkId");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1,
                column: "DogParkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2,
                column: "DogParkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3,
                column: "DogParkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4,
                column: "DogParkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5,
                column: "DogParkId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 6,
                column: "DogParkId",
                value: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_DogPark_DogParkId",
                table: "Dogs",
                column: "DogParkId",
                principalTable: "DogPark",
                principalColumn: "DogParkId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
