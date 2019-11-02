﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksLookup.Models;

namespace ParksLookup.Migrations
{
    [DbContext(typeof(ParksLookupContext))]
    [Migration("20191102013958_DataUpdate2")]
    partial class DataUpdate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksLookup.Models.NativeSpecies", b =>
                {
                    b.Property<int>("NativeSpeciesId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<string>("CommonName");

                    b.Property<string>("ConservationStatus");

                    b.Property<string>("Kingdom");

                    b.Property<int>("ParkId");

                    b.Property<string>("Species");

                    b.Property<string>("SpeciesDescription");

                    b.HasKey("NativeSpeciesId");

                    b.HasIndex("ParkId");

                    b.ToTable("NativeSpecies");

                    b.HasData(
                        new
                        {
                            NativeSpeciesId = 1,
                            Class = "Mammalia",
                            CommonName = "American Black Bear",
                            ConservationStatus = "least concern",
                            Kingdom = "Animalia",
                            ParkId = 1,
                            Species = "Ursa americanus",
                            SpeciesDescription = "American black bears are omnivores, with diets varying greatly depending on season and location. They typically live in largely forested areas, but do leave forests in search of food. Sometimes they become attracted to human communities because of the immediate availability of food. The American black bear is the world's most common bear species."
                        });
                });

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

            modelBuilder.Entity("ParksLookup.Models.NativeSpecies", b =>
                {
                    b.HasOne("ParksLookup.Models.Park", "Park")
                        .WithMany("NativeSpecies")
                        .HasForeignKey("ParkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}