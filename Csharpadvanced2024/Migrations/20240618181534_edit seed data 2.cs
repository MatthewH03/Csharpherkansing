using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    public partial class editseeddata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Subtitle", "Title" },
                values: new object[] { "Genesteld in de bergen, biedt dit gezellige huisje een adembenemend uitzicht en een rustige sfeer. Perfect voor een weekendje weg.", "Rustig toevluchtsoord", "Rustiek Berg Huisje" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Rooms", "Subtitle", "Title" },
                values: new object[] { "Een stijlvol en modern appartement gelegen in het bruisende stadscentrum. Dicht bij alle belangrijke bezienswaardigheden en openbaar vervoer.", 2, "In het hart van het centrum", "Modern Stadsappartement" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Rooms", "Subtitle", "Title" },
                values: new object[] { "Ervaar luxe in dit hotel aan het strand met een heerlijk bad en een adembenemend uitzicht op de oceaan. Perfect voor families en groepen.", 10, "Luxe hotelverblijf met zeezicht", "Hotel aan het Strand" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Subtitle", "Title" },
                values: new object[] { "Een charmant huisje op het platteland, omgeven door groen. Ideaal voor een rustige vakantie met familie of vrienden.", "Charmant en rustig", "Gezellig Landelijk Huisje" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Subtitle", "Title" },
                values: new object[] { "Verblijf in een prachtig bewaard gebleven historisch huis met antieke meubels en moderne voorzieningen.", "Elegant en historisch", "Historisch Huis" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Subtitle", "Title" },
                values: new object[] { "Een stijlvolle kamer in het hart van de stad, met gemakkelijke toegang tot het nachtleven, eetgelegenheden en winkels.", "Stijlvol wonen in het centrum", "Stads Kamer" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Subtitle", "Title" },
                values: new object[] { "Een rustig chalet aan het meer, perfect voor vissen, kajakken en genieten van de natuur.", "Ontspannen bij het water", "Chalet aan het Meer" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "Rooms",
                value: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Subtitle", "Title" },
                values: new object[] { "Nestled in the mountains, this cozy cottage offers stunning views and a peaceful atmosphere. Perfect for a weekend getaway.", "Peaceful retreat", "Rustic Mountain Cottage" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Rooms", "Subtitle", "Title" },
                values: new object[] { "A stylish and modern apartment located in the bustling city center. Close to all major attractions and public transport.", 1, "In the heart of downtown", "Modern City Apartment" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Rooms", "Subtitle", "Title" },
                values: new object[] { "Experience luxury at this beachfront hotel with a nice bath and stunning ocean views. Perfect for families and groups.", 100, "Luxurious hotel stay with ocean view", "Beachfront Hotel" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Subtitle", "Title" },
                values: new object[] { "A charming country cottage surrounded by greenery. Ideal for a quiet retreat with family or friends.", "Charming and quiet", "Cozy Country Cottage" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Subtitle", "Title" },
                values: new object[] { "Stay in a beautifully preserved historic house with antique furnishings and modern amenities.", "Elegance and history", "Historic House" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Subtitle", "Title" },
                values: new object[] { "A stylish room in the heart of the city, with easy access to nightlife, dining, and shopping.", "Stylish downtown living", "City Room" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Subtitle", "Title" },
                values: new object[] { "A peaceful chalet by the lake, perfect for fishing, kayaking, and enjoying nature.", "Relax by the water", "Lakeside Chalet" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "Rooms",
                value: 150);
        }
    }
}
