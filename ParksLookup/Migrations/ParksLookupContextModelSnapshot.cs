﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksLookup.Models;

namespace ParksLookup.Migrations
{
    [DbContext(typeof(ParksLookupContext))]
    partial class ParksLookupContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksLookup.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ParkFounded");

                    b.Property<string>("ParkLocation");

                    b.Property<string>("ParkName");

                    b.Property<string>("ParkSize");

                    b.Property<string>("ParkType");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            ParkFounded = "1872",
                            ParkLocation = "Wyoming, Montana, and Idaho",
                            ParkName = "Yellowstone",
                            ParkSize = "3,468 sq miles",
                            ParkType = "National"
                        },
                        new
                        {
                            ParkId = 2,
                            ParkFounded = "1919",
                            ParkLocation = "Utah",
                            ParkName = "Zion",
                            ParkSize = "229 sq miles",
                            ParkType = "National"
                        },
                        new
                        {
                            ParkId = 3,
                            ParkFounded = "1910",
                            ParkLocation = "Montana",
                            ParkName = "Glacier",
                            ParkSize = "16,000 sq miles",
                            ParkType = "National"
                        },
                        new
                        {
                            ParkId = 4,
                            ParkFounded = "1872",
                            ParkLocation = "Washington",
                            ParkName = "Cape Disappointment",
                            ParkSize = "2,023 sq acres",
                            ParkType = "State"
                        },
                        new
                        {
                            ParkId = 5,
                            ParkFounded = "1872",
                            ParkLocation = "Washington",
                            ParkName = "Wallace Falls",
                            ParkSize = "1,380 sq acres",
                            ParkType = "State"
                        },
                        new
                        {
                            ParkId = 6,
                            ParkFounded = "1937",
                            ParkLocation = "Oregon",
                            ParkName = "Rooster Rock",
                            ParkSize = "812 sq acres",
                            ParkType = "State"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
