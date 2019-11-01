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
                    new NativeSpecies { NativeSpeciesId = 1, Kingdom = "Animalia", Class = "Mammalia", Species = "Ursa americanus", CommonName = "American Black Bear", SpeciesDescription = "American black bears are omnivores, with diets varying greatly depending on season and location. They typically live in largely forested areas, but do leave forests in search of food. Sometimes they become attracted to human communities because of the immediate availability of food. The American black bear is the world's most common bear species.", ConservationStatus = "least concern" }             
                );
        }
    }
}