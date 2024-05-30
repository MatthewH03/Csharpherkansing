using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    public partial class fixednr8type2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "Type",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "Type",
                value: 1);
        }
    }
}
