using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    public partial class moreseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "LandlordId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "IsCover", "LandlordId", "LocationId", "Url" },
                values: new object[,]
                {
                    { 6, true, null, 3, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/Calle_Kirkegata%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_76.jpg/1920px-Calle_Kirkegata%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_76.jpg" },
                    { 7, true, null, 4, "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fd/Calle_Storgata%2C_Troms%C3%B8%2C_Noruega%2C_2019-09-04%2C_DD_69.jpg/1920px-Calle_Storgata%2C_Troms%C3%B8%2C_Noruega%2C_2019-09-04%2C_DD_69.jpg" },
                    { 8, true, null, 4, "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Nav%C3%ADo_Costa_Pacifica_desde_Aksla,_%C3%85lesund,_Noruega,_2019-09-01,_DD_04.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "LandlordId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Description", "Features", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "Subtitle", "Title", "Type" },
                values: new object[,]
                {
                    { 5, "Dit is de vijfde locatie", 0, 3, 5, 400f, 3, "Mooie locatie", "Locatie nr. 5", 0 },
                    { 6, "Dit is de zesde locatie", 0, 1, 6, 400f, 6, "Mooie locatie", "Locatie nr. 6", 0 },
                    { 7, "Dit is de zevende locatie", 0, 2, 7, 400f, 7, "Mooie locatie", "Locatie nr. 7", 0 },
                    { 8, "Dit is de achtste locatie", 0, 3, 8, 400f, 8, "Mooie locatie", "Locatie nr. 8", 0 },
                    { 9, "Dit is de negenste locatie", 0, 1, 9, 400f, 9, "Mooie locatie", "Locatie nr. 9", 0 },
                    { 10, "Dit is de tiende locatie", 0, null, 10, 400f, 3, "Mooie locatie", "Locatie nr. 10", 0 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "IsCover", "LandlordId", "LocationId", "Url" },
                values: new object[,]
                {
                    { 9, false, null, 5, "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Edificio_de_la_Asociaci%C3%B3n_de_Skippers%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_88.jpg/1920px-Edificio_de_la_Asociaci%C3%B3n_de_Skippers%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_88.jpg" },
                    { 10, true, null, 5, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Escuela_Asp%C3%B8y_desde_Aksla%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_03.jpg/1920px-Escuela_Asp%C3%B8y_desde_Aksla%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_03.jpg" },
                    { 11, false, null, 6, "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Edificio_de_la_Asociaci%C3%B3n_de_Skippers%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_88.jpg/1920px-Edificio_de_la_Asociaci%C3%B3n_de_Skippers%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_88.jpg" },
                    { 12, true, null, 6, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Escuela_Asp%C3%B8y_desde_Aksla%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_03.jpg/1920px-Escuela_Asp%C3%B8y_desde_Aksla%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_03.jpg" },
                    { 13, false, null, 7, "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Escuela_Asp%C3%B8y,_%C3%85lesund,_Noruega,_2019-09-01,_DD_79.jpg" },
                    { 14, false, null, 7, "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Escuela_Asp%C3%B8y,_%C3%85lesund,_Noruega,_2019-09-01,_DD_80.jpg" },
                    { 15, false, null, 8, "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Escuela_secundaria_Latinskolen%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_87.jpg/1280px-Escuela_secundaria_Latinskolen%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_87.jpg" },
                    { 16, false, null, 8, "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Iglesia_parroquial,_%C3%85lesund,_Noruega,_2019-09-01,_DD_77.jpg" },
                    { 17, false, null, 9, "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Iglesia_parroquial%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_86.jpg/1280px-Iglesia_parroquial%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_86.jpg" },
                    { 18, false, null, 9, "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Nav%C3%ADo_Costa_Pacifica_desde_Aksla,_%C3%85lesund,_Noruega,_2019-09-01,_DD_04.jpg" },
                    { 19, false, null, 10, "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Nav%C3%ADo_Costa_Pacifica_desde_Aksla,_%C3%85lesund,_Noruega,_2019-09-01,_DD_04.jpg" },
                    { 20, false, null, 10, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg/1920px-Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "LandlordId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "LandlordId",
                value: null);
        }
    }
}
