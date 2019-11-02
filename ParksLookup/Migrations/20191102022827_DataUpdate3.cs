using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class DataUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NativeSpecies",
                columns: new[] { "NativeSpeciesId", "Class", "CommonName", "ConservationStatus", "Kingdom", "ParkId", "Species", "SpeciesDescription" },
                values: new object[,]
                {
                    { 2, "Mammalia", "Hoary Marmot", "least concern", "Animalia", 3, "Marmota caligata", "The hoary marmot is a large, bulky, ground squirrel, with short, heavy limbs, and a broad head. They frequently sun themselves on rocks, spending as much as 44% of their time in the morning doing so, although they will shelter in their burrows or otherwise seek shade in especially warm weather. They forage for the rest of the day, returning to their burrows to sleep during the night and  hibernate seven to eight months a year in burrows." },
                    { 3, "Cataceae", "Grizzly Bear Prickly Pear Cactus", "least concern", "Plantae", 2, "Opuntia erinacea", "The Grizzly Bear Prickly Pear cactus forms small, low clumps with erect branches. The pads are thickly covered with long, gray, downward-pointing spines. Flower color varies from rose to yellow depending on variety and the fruit is dry and spiny." },
                    { 4, "Reptilia", "Desert Tortoise", "vulnerable", "Animalia", 2, "Gopherus agassizii", "The desert tortoise lives about 50 to 80 years; it grows slowly and generally has a low reproductive rate. Desert tortoises can live in areas with ground temperatures exceeding 140 °F (60 °C) because of their ability to dig burrows and escape the heat. At least 95% of their lives are spent in burrows, which helps them to regulate body temperature and reduce water loss. They are most active after seasonal rains and are inactive during most of the year." },
                    { 5, "Pinaceae", "White-barked Pine", "endangered", "Plantae", 2, "Pinus Albicaulis", "The whitebark pine is typically the highest-elevation pine tree found in Western US mountain ranges and often marks the tree line. Thus, it is often found as krummholz, trees growing close to the ground that have been dwarfed by exposure. In more favorable conditions, the trees may grow to 29 meters (95 ft) in height." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NativeSpecies",
                keyColumn: "NativeSpeciesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NativeSpecies",
                keyColumn: "NativeSpeciesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NativeSpecies",
                keyColumn: "NativeSpeciesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NativeSpecies",
                keyColumn: "NativeSpeciesId",
                keyValue: 5);
        }
    }
}
