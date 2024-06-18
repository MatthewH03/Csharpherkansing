using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    public partial class editedseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Features", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[] { "Nestled in the mountains, this cozy cottage offers stunning views and a peaceful atmosphere. Perfect for a weekend getaway.", 36, 6, 150f, 3, "Peaceful retreat", "Rustic Mountain Cottage", 1 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Features", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[] { "A stylish and modern apartment located in the bustling city center. Close to all major attractions and public transport.", 12, 2, 200f, 1, "In the heart of downtown", "Modern City Apartment", 0 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Features", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[] { "Experience luxury at this beachfront hotel with a nice bath and stunning ocean views. Perfect for families and groups.", 60, 8, 400f, 100, "Luxurious hotel stay with ocean view", "Beachfront Hotel", 4 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Features", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[] { "A charming country cottage surrounded by greenery. Ideal for a quiet retreat with family or friends.", 0, 5, 120f, 2, "Charming and quiet", "Cozy Country Cottage", 1 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Features", "NumberOfGuests", "PricePerDay", "Subtitle", "Title" },
                values: new object[] { "Stay in a beautifully preserved historic house with antique furnishings and modern amenities.", 29, 15, 400f, "Elegance and history", "Historic House" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Features", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[] { "A stylish room in the heart of the city, with easy access to nightlife, dining, and shopping.", 4, 2, 250f, 1, "Stylish downtown living", "City Room", 3 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Features", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[] { "A peaceful chalet by the lake, perfect for fishing, kayaking, and enjoying nature.", 5, 4, 180f, 2, "Relax by the water", "Lakeside Chalet", 2 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Features", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[] { "Het Grand Central Hotel biedt een perfecte combinatie van luxe en comfort. Gelegen in het hart van de stad, op loopafstand van de belangrijkste bezienswaardigheden, restaurants en winkels.", 36, 1, 300, 150f, 150, "Luxueus verblijf in het hart van de stad", "Grand Central Hotel", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Features", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[] { "Dit is de eerste locatie", 1, 10, 100f, 5, "Mooie locatie", "Locatie nr. 1", 0 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Features", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[] { "Dit is de tweede locatie", 2, 10, 300f, 5, "Mooie locatie", "Locatie nr. 2", 1 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Features", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[] { "Dit is de vijfde locatie", 4, 5, 200f, 3, "Mooie locatie", "Locatie nr. 5", 2 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Features", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[] { "Dit is de zesde locatie", 8, 6, 400f, 6, "Mooie locatie", "Locatie nr. 6", 4 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Features", "NumberOfGuests", "PricePerDay", "Subtitle", "Title" },
                values: new object[] { "Dit is de zevende locatie", 16, 7, 100f, "Mooie locatie", "Locatie nr. 7" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Features", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[] { "Dit is de achtste locatie", 32, 8, 300f, 8, "Mooie locatie", "Locatie nr. 8", 0 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Features", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[] { "Dit is de negenste locatie", 2, 9, 200f, 9, "Mooie locatie", "Locatie nr. 9", 0 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Features", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[] { "Dit is de tiende locatie", 4, null, 10, 400f, 3, "Mooie locatie", "Locatie nr. 10", 1 });
        }
    }
}
