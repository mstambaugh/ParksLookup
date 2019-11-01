using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "ParkFounded", "ParkLocation", "ParkName", "ParkSize", "ParkType" },
                values: new object[,]
                {
                    { 1, "1872", "Wyoming, Montana, and Idaho", "Yellowstone", "3,468 sq miles", "National" },
                    { 2, "1919", "Southern Utah", "Zion", "229 sq miles", "National" },
                    { 3, "1910", "Northwestern Montana", "Glacier", "16,000 sq miles", "National" },
                    { 4, "1872", "Washington", "Cape Disappointment", "2,023 sq acres", "State" },
                    { 5, "1872", "Washington", "Wallace Falls", "1,380 sq acres", "State" },
                    { 6, "1937", "Oregon", "Rooster Rock", "812 sq acres", "State" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);
        }
    }
}
