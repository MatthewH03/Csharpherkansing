using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    public partial class addlandlords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 1, 55, "John", "Doe" });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 2, 40, "Henk", "Pieters" });

            migrationBuilder.InsertData(
                table: "Landlords",
                columns: new[] { "Id", "Age", "FirstName", "LastName" },
                values: new object[] { 3, 36, "Jan", "Hollands" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Landlords",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
