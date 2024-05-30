using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LandlordId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_LandlordId",
                table: "Images",
                column: "LandlordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Landlords_LandlordId",
                table: "Images",
                column: "LandlordId",
                principalTable: "Landlords",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Landlords_LandlordId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_LandlordId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "LandlordId",
                table: "Images");
        }
    }
}
