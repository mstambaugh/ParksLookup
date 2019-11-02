using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class DataUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NativeSpecies",
                columns: table => new
                {
                    NativeSpeciesId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParkId = table.Column<int>(nullable: false),
                    Kingdom = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    CommonName = table.Column<string>(nullable: true),
                    SpeciesDescription = table.Column<string>(nullable: true),
                    ConservationStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NativeSpecies", x => x.NativeSpeciesId);
                    table.ForeignKey(
                        name: "FK_NativeSpecies_Parks_ParkId",
                        column: x => x.ParkId,
                        principalTable: "Parks",
                        principalColumn: "ParkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "NativeSpecies",
                columns: new[] { "NativeSpeciesId", "Class", "CommonName", "ConservationStatus", "Kingdom", "ParkId", "Species", "SpeciesDescription" },
                values: new object[] { 1, "Mammalia", "American Black Bear", "least concern", "Animalia", 1, "Ursa americanus", "American black bears are omnivores, with diets varying greatly depending on season and location. They typically live in largely forested areas, but do leave forests in search of food. Sometimes they become attracted to human communities because of the immediate availability of food. The American black bear is the world's most common bear species." });

            migrationBuilder.CreateIndex(
                name: "IX_NativeSpecies_ParkId",
                table: "NativeSpecies",
                column: "ParkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NativeSpecies");
        }
    }
}
