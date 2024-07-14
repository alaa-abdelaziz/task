using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIs.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Governorate",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Cairo" });

            migrationBuilder.InsertData(
                table: "Governorate",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Giza" });

            migrationBuilder.InsertData(
                table: "Governorate",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Alexandria" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "GovernorateId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Cairo Downtown" },
                    { 2, 1, "Zamalek" },
                    { 3, 1, "Kasr El Nile" },
                    { 4, 1, "Rehab" },
                    { 5, 1, "Katameya" },
                    { 6, 1, "Madinty" },
                    { 7, 1, "Rod Alfarag" },
                    { 8, 1, "Sheraton" },
                    { 9, 1, "El-Gamaleya" },
                    { 10, 1, "10th of Ramadan City" },
                    { 11, 1, "Helmeyat Alzaytoun" },
                    { 12, 1, "New Nozha" },
                    { 13, 1, "Capital New" },
                    { 14, 2, "السادس من أكتوبر" },
                    { 15, 2, "Sixth of October" },
                    { 16, 2, "Cheikh Zayed" },
                    { 17, 2, "Hawamdiyah" },
                    { 18, 2, "Al Badrasheen" },
                    { 19, 2, "Saf" },
                    { 20, 2, "Atfih" },
                    { 21, 2, "Al Ayat" },
                    { 22, 2, "Al-Bawaiti" },
                    { 23, 2, "ManshiyetAl Qanater" },
                    { 24, 2, "Oaseem" },
                    { 25, 2, "Kerdasa" },
                    { 26, 3, "ابو قير" },
                    { 27, 3, "Abu Qir" },
                    { 28, 3, "Al Ibrahimeyah" },
                    { 29, 3, "Azarita" },
                    { 30, 3, "Anfoushi" },
                    { 31, 3, "Dekheila" },
                    { 32, 3, "El Soyof" },
                    { 33, 3, "Ameria" },
                    { 34, 3, "El Labban" },
                    { 35, 3, "Al Mafrouza" },
                    { 36, 3, "El Montaza" },
                    { 37, 3, "Mansheya" },
                    { 38, 3, "Naseria" },
                    { 39, 3, "Ambrozo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
