using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    public partial class adjustedfeaturesandtypesfortesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "IsCover", "LandlordId", "LocationId", "Url" },
                values: new object[,]
                {
                    { 22, true, null, 2, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg/1920px-Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg" },
                    { 23, true, null, 2, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg/1920px-Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Features", "Type" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Features",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "Features",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Features", "Type" },
                values: new object[] { 32, 0 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "Features",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "Features",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Features", "Type" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "Features",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "Features",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Features", "Type" },
                values: new object[] { 6, 5 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "Features",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "Features",
                value: 2);
        }
    }
}
