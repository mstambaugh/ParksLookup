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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(
                    new Park { ParkId = 1, ParkName = "YellowStone", ParkType = "National", ParkLocation = "Wyoming, Montana, and Idaho", ParkSize = "3,468 sq miles", ParkFounded = "1872" },
                    new Park { ParkId = 2, ParkName = "Zion", ParkType = "National", ParkLocation = "Southern Utah", ParkSize = "229 sq miles", ParkFounded = "1919" },
                    new Park { ParkId = 3, ParkName = "Glacier", ParkType = "National", ParkLocation = "Northwestern Montana", ParkSize = "16,000 sq miles", ParkFounded = "1910" },
                    new Park { ParkId = 4, ParkName = "YellowStone", ParkType = "National", ParkLocation = "Wyoming, Montana, and Idaho", ParkSize = "3,468 sq miles", ParkFounded = "1872" }
                );
        }
    }
}