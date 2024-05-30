using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    public partial class addimagetolandlord1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Gazania_krebsiana%2C_Quebec_city%2C_Quebec%2C_Canada_131.jpg/1280px-Gazania_krebsiana%2C_Quebec_city%2C_Quebec%2C_Canada_131.jpg");

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "IsCover", "LandlordId", "LocationId", "Url" },
                values: new object[] { 3, true, 1, null, "https://images.unsplash.com/photo-1500648767791-00dcc994a43e?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/2011_Berat%2C_Cerkiew_%C5%9Bw._Teodora.JPG/1024px-2011_Berat%2C_Cerkiew_%C5%9Bw._Teodora.JPG");
        }
    }
}
