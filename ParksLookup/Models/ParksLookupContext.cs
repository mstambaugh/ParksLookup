using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
    public class ParksLookupContext : DbContext
    {
        public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }
        public DbSet<NativeSpecies> NativeSpecies { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(
                    new Park { ParkId = 1, ParkName = "Yellowstone", ParkType = "National", ParkLocation = "Wyoming, Montana, and Idaho", ParkSize = "3,468 sq miles", ParkFounded = "1872" },
                    new Park { ParkId = 2, ParkName = "Zion", ParkType = "National", ParkLocation = "Utah", ParkSize = "229 sq miles", ParkFounded = "1919" },
                    new Park { ParkId = 3, ParkName = "Glacier", ParkType = "National", ParkLocation = "Montana", ParkSize = "16,000 sq miles", ParkFounded = "1910" },
                    new Park { ParkId = 4, ParkName = "Cape Disappointment", ParkType = "State", ParkLocation = "Washington", ParkSize = "2,023 sq acres", ParkFounded = "1872" },
                    new Park { ParkId = 5, ParkName = "Wallace Falls", ParkType = "State", ParkLocation = "Washington", ParkSize = "1,380 sq acres", ParkFounded = "1872" },
                    new Park { ParkId = 6, ParkName = "Rooster Rock", ParkType = "State", ParkLocation = "Oregon", ParkSize = "812 sq acres", ParkFounded = "1937" }
                );
            builder.Entity<NativeSpecies>()
                .HasData(
                    new NativeSpecies { NativeSpeciesId = 1, ParkId = 1, Kingdom = "Animalia", Class = "Mammalia", Species = "Ursa americanus", CommonName = "American Black Bear", SpeciesDescription = "American black bears are omnivores, with diets varying greatly depending on season and location. They typically live in largely forested areas, but do leave forests in search of food. Sometimes they become attracted to human communities because of the immediate availability of food. The American black bear is the world's most common bear species.", ConservationStatus = "least concern" },      
                    
                    new NativeSpecies { NativeSpeciesId = 2, ParkId = 3, Kingdom = "Animalia", Class = "Mammalia", Species = "Marmota caligata", CommonName = "Hoary Marmot", SpeciesDescription = "The hoary marmot is a large, bulky, ground squirrel, with short, heavy limbs, and a broad head. They frequently sun themselves on rocks, spending as much as 44% of their time in the morning doing so, although they will shelter in their burrows or otherwise seek shade in especially warm weather. They forage for the rest of the day, returning to their burrows to sleep during the night and  hibernate seven to eight months a year in burrows.", ConservationStatus = "least concern" },
                    new NativeSpecies { NativeSpeciesId = 3, ParkId = 2, Kingdom = "Plantae", Class = "Cataceae", Species = "Opuntia erinacea", CommonName = "Grizzly Bear Prickly Pear Cactus", SpeciesDescription = "The Grizzly Bear Prickly Pear cactus forms small, low clumps with erect branches. The pads are thickly covered with long, gray, downward-pointing spines. Flower color varies from rose to yellow depending on variety and the fruit is dry and spiny.", ConservationStatus = "least concern" },
                    new NativeSpecies { NativeSpeciesId = 4, ParkId = 2, Kingdom = "Animalia", Class = "Reptilia", Species = "Gopherus agassizii", CommonName = "Desert Tortoise", SpeciesDescription = "The desert tortoise lives about 50 to 80 years; it grows slowly and generally has a low reproductive rate. Desert tortoises can live in areas with ground temperatures exceeding 140 °F (60 °C) because of their ability to dig burrows and escape the heat. At least 95% of their lives are spent in burrows, which helps them to regulate body temperature and reduce water loss. They are most active after seasonal rains and are inactive during most of the year.", ConservationStatus = "vulnerable" },
                    new NativeSpecies { NativeSpeciesId = 5, ParkId = 2, Kingdom = "Plantae", Class = "Pinaceae", Species = "Pinus Albicaulis", CommonName = "White-barked Pine", SpeciesDescription = "The whitebark pine is typically the highest-elevation pine tree found in Western US mountain ranges and often marks the tree line. Thus, it is often found as krummholz, trees growing close to the ground that have been dwarfed by exposure. In more favorable conditions, the trees may grow to 29 meters (95 ft) in height.", ConservationStatus = "endangered" }
                );
        }
    }
}