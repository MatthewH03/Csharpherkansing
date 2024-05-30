using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    public partial class addlandlordtolocationtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandlordLocation");

            migrationBuilder.AddColumn<int>(
                name: "LandlordId",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LandlordId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LandlordId",
                table: "Locations",
                column: "LandlordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Landlords_LandlordId",
                table: "Locations",
                column: "LandlordId",
                principalTable: "Landlords",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Landlords_LandlordId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_LandlordId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "LandlordId",
                table: "Locations");

            migrationBuilder.CreateTable(
                name: "LandlordLocation",
                columns: table => new
                {
                    LandlordId = table.Column<int>(type: "int", nullable: false),
                    LocationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandlordLocation", x => new { x.LandlordId, x.LocationsId });
                    table.ForeignKey(
                        name: "FK_LandlordLocation_Landlords_LandlordId",
                        column: x => x.LandlordId,
                        principalTable: "Landlords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LandlordLocation_Locations_LocationsId",
                        column: x => x.LocationsId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LandlordLocation_LocationsId",
                table: "LandlordLocation",
                column: "LocationsId");
        }
    }
}
