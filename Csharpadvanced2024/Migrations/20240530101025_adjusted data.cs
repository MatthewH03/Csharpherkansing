using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    public partial class adjusteddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "LandlordId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsCover",
                value: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsCover",
                value: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsCover",
                value: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsCover",
                value: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsCover",
                value: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "IsCover",
                value: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "IsCover",
                value: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "IsCover",
                value: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "IsCover",
                value: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "IsCover",
                value: true);

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "IsCover", "LandlordId", "LocationId", "Url" },
                values: new object[] { 21, true, null, 3, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg/1920px-Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "LandlordId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsCover",
                value: false);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsCover",
                value: false);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsCover",
                value: false);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsCover",
                value: false);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsCover",
                value: false);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "IsCover",
                value: false);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "IsCover",
                value: false);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "IsCover",
                value: false);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "IsCover",
                value: false);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "IsCover",
                value: false);
        }
    }
}
