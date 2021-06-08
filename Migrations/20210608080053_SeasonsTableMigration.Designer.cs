﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesApis.DBContexts;

namespace MoviesApis.Migrations
{
    [DbContext(typeof(MySqlDbContext))]
    [Migration("20210608080053_SeasonsTableMigration")]
    partial class SeasonsTableMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("MoviesApis.Models.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SeriesId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("SeriesId");

                    b.ToTable("Seasons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDateTime = new DateTime(2020, 7, 25, 3, 55, 41, 206, DateTimeKind.Local).AddTicks(1934),
                            SeriesId = 590,
                            Title = "Mountain hard drive Plastic Mississippi"
                        },
                        new
                        {
                            Id = 2,
                            CreationDateTime = new DateTime(2020, 8, 2, 22, 18, 26, 886, DateTimeKind.Local).AddTicks(2520),
                            SeriesId = 600,
                            Title = "Flats Key Nebraska Consultant"
                        },
                        new
                        {
                            Id = 3,
                            CreationDateTime = new DateTime(2020, 10, 31, 11, 46, 57, 12, DateTimeKind.Local).AddTicks(8727),
                            SeriesId = 500,
                            Title = "bi-directional Gorgeous Metal Fish Internal navigating"
                        },
                        new
                        {
                            Id = 4,
                            CreationDateTime = new DateTime(2021, 1, 25, 13, 44, 23, 812, DateTimeKind.Local).AddTicks(2630),
                            SeriesId = 246,
                            Title = "Auto Loan Account Rustic Curve Tasty Frozen Bike"
                        },
                        new
                        {
                            Id = 5,
                            CreationDateTime = new DateTime(2020, 9, 3, 19, 24, 44, 598, DateTimeKind.Local).AddTicks(149),
                            SeriesId = 850,
                            Title = "cyan Buckinghamshire alarm bypassing"
                        },
                        new
                        {
                            Id = 6,
                            CreationDateTime = new DateTime(2021, 4, 1, 4, 48, 44, 7, DateTimeKind.Local).AddTicks(6899),
                            SeriesId = 644,
                            Title = "ADP magnetic District mindshare"
                        },
                        new
                        {
                            Id = 7,
                            CreationDateTime = new DateTime(2020, 10, 31, 16, 46, 57, 18, DateTimeKind.Local).AddTicks(6274),
                            SeriesId = 731,
                            Title = "revolutionize Home Loan Account hub Configuration"
                        },
                        new
                        {
                            Id = 8,
                            CreationDateTime = new DateTime(2021, 4, 1, 6, 33, 0, 19, DateTimeKind.Local).AddTicks(7123),
                            SeriesId = 102,
                            Title = "Solutions SAS Licensed asynchronous"
                        },
                        new
                        {
                            Id = 9,
                            CreationDateTime = new DateTime(2020, 10, 14, 6, 20, 49, 365, DateTimeKind.Local).AddTicks(686),
                            SeriesId = 257,
                            Title = "Massachusetts program Technician hack"
                        },
                        new
                        {
                            Id = 10,
                            CreationDateTime = new DateTime(2021, 2, 27, 10, 32, 40, 203, DateTimeKind.Local).AddTicks(9819),
                            SeriesId = 512,
                            Title = "Expressway Center Coordinator tangible"
                        },
                        new
                        {
                            Id = 11,
                            CreationDateTime = new DateTime(2021, 4, 22, 22, 27, 47, 386, DateTimeKind.Local).AddTicks(759),
                            SeriesId = 369,
                            Title = "Namibia Dollar end-to-end transmitting Nevada"
                        },
                        new
                        {
                            Id = 12,
                            CreationDateTime = new DateTime(2020, 8, 29, 4, 55, 49, 932, DateTimeKind.Local).AddTicks(6876),
                            SeriesId = 691,
                            Title = "Incredible Rubber Table Personal Loan Account Handmade Port"
                        },
                        new
                        {
                            Id = 13,
                            CreationDateTime = new DateTime(2020, 12, 15, 8, 12, 35, 973, DateTimeKind.Local).AddTicks(3027),
                            SeriesId = 825,
                            Title = "Cliffs Grocery, Sports & Jewelery Lithuanian Litas engage"
                        },
                        new
                        {
                            Id = 14,
                            CreationDateTime = new DateTime(2020, 12, 11, 21, 3, 25, 567, DateTimeKind.Local).AddTicks(5317),
                            SeriesId = 129,
                            Title = "Circle Antarctica (the territory South of 60 deg S) Wooden Seamless"
                        },
                        new
                        {
                            Id = 15,
                            CreationDateTime = new DateTime(2021, 1, 16, 23, 58, 52, 485, DateTimeKind.Local).AddTicks(2220),
                            SeriesId = 932,
                            Title = "Organic Cotton Incredible Granite Ball HDD"
                        },
                        new
                        {
                            Id = 16,
                            CreationDateTime = new DateTime(2020, 9, 9, 14, 52, 34, 921, DateTimeKind.Local).AddTicks(4181),
                            SeriesId = 787,
                            Title = "context-sensitive Fantastic monitor Pakistan Rupee"
                        },
                        new
                        {
                            Id = 17,
                            CreationDateTime = new DateTime(2020, 8, 26, 9, 28, 34, 834, DateTimeKind.Local).AddTicks(3756),
                            SeriesId = 592,
                            Title = "mobile Toys, Clothing & Health Mississippi Architect"
                        },
                        new
                        {
                            Id = 18,
                            CreationDateTime = new DateTime(2020, 8, 21, 10, 21, 45, 746, DateTimeKind.Local).AddTicks(8758),
                            SeriesId = 198,
                            Title = "Incredible Cotton Cheese productize Handmade Optimized"
                        },
                        new
                        {
                            Id = 19,
                            CreationDateTime = new DateTime(2020, 9, 2, 12, 46, 23, 711, DateTimeKind.Local).AddTicks(1200),
                            SeriesId = 501,
                            Title = "throughput array Avon Buckinghamshire"
                        },
                        new
                        {
                            Id = 20,
                            CreationDateTime = new DateTime(2020, 12, 31, 13, 25, 45, 324, DateTimeKind.Local).AddTicks(9507),
                            SeriesId = 680,
                            Title = "Practical Wooden Fish neural array Factors"
                        },
                        new
                        {
                            Id = 21,
                            CreationDateTime = new DateTime(2021, 1, 3, 3, 51, 36, 876, DateTimeKind.Local).AddTicks(622),
                            SeriesId = 563,
                            Title = "Direct compelling open system Netherlands Antillian Guilder"
                        },
                        new
                        {
                            Id = 22,
                            CreationDateTime = new DateTime(2020, 7, 19, 2, 12, 23, 381, DateTimeKind.Local).AddTicks(7409),
                            SeriesId = 980,
                            Title = "bypassing reciprocal microchip Agent"
                        },
                        new
                        {
                            Id = 23,
                            CreationDateTime = new DateTime(2021, 3, 1, 10, 54, 28, 505, DateTimeKind.Local).AddTicks(3532),
                            SeriesId = 609,
                            Title = "fresh-thinking Tasty Rubber Tuna Concrete infrastructures"
                        },
                        new
                        {
                            Id = 24,
                            CreationDateTime = new DateTime(2021, 5, 14, 10, 23, 34, 479, DateTimeKind.Local).AddTicks(2845),
                            SeriesId = 585,
                            Title = "Fresh Books & Beauty neural Electronics & Shoes"
                        },
                        new
                        {
                            Id = 25,
                            CreationDateTime = new DateTime(2020, 12, 9, 17, 24, 48, 689, DateTimeKind.Local).AddTicks(9083),
                            SeriesId = 152,
                            Title = "Bypass Rustic Steel Data"
                        },
                        new
                        {
                            Id = 26,
                            CreationDateTime = new DateTime(2020, 11, 16, 11, 19, 31, 705, DateTimeKind.Local).AddTicks(6261),
                            SeriesId = 820,
                            Title = "Identity open-source Michigan Investment Account"
                        },
                        new
                        {
                            Id = 27,
                            CreationDateTime = new DateTime(2021, 1, 6, 18, 59, 7, 450, DateTimeKind.Local).AddTicks(7804),
                            SeriesId = 212,
                            Title = "Administrator bandwidth Practical Steel Mouse SAS"
                        },
                        new
                        {
                            Id = 28,
                            CreationDateTime = new DateTime(2020, 11, 23, 8, 46, 23, 801, DateTimeKind.Local).AddTicks(7746),
                            SeriesId = 700,
                            Title = "deliver Ergonomic Wooden Ball Designer frictionless"
                        },
                        new
                        {
                            Id = 29,
                            CreationDateTime = new DateTime(2021, 5, 28, 19, 47, 32, 449, DateTimeKind.Local).AddTicks(8605),
                            SeriesId = 99,
                            Title = "payment Rustic Concrete Towels synthesizing Lead"
                        },
                        new
                        {
                            Id = 30,
                            CreationDateTime = new DateTime(2020, 11, 22, 17, 45, 37, 735, DateTimeKind.Local).AddTicks(1235),
                            SeriesId = 284,
                            Title = "workforce Technician Producer National"
                        },
                        new
                        {
                            Id = 31,
                            CreationDateTime = new DateTime(2020, 10, 16, 15, 58, 57, 223, DateTimeKind.Local).AddTicks(8340),
                            SeriesId = 236,
                            Title = "Consultant Berkshire even-keeled Fort"
                        },
                        new
                        {
                            Id = 32,
                            CreationDateTime = new DateTime(2020, 12, 26, 15, 40, 11, 439, DateTimeKind.Local).AddTicks(2772),
                            SeriesId = 961,
                            Title = "microchip Mission toolset Paradigm"
                        },
                        new
                        {
                            Id = 33,
                            CreationDateTime = new DateTime(2020, 11, 14, 8, 43, 18, 968, DateTimeKind.Local).AddTicks(9877),
                            SeriesId = 592,
                            Title = "Guinea Crossroad digital focus group"
                        },
                        new
                        {
                            Id = 34,
                            CreationDateTime = new DateTime(2020, 12, 9, 10, 7, 12, 622, DateTimeKind.Local).AddTicks(4393),
                            SeriesId = 325,
                            Title = "portals bandwidth-monitored withdrawal Auto Loan Account"
                        },
                        new
                        {
                            Id = 35,
                            CreationDateTime = new DateTime(2021, 6, 7, 18, 36, 6, 187, DateTimeKind.Local).AddTicks(8813),
                            SeriesId = 376,
                            Title = "turn-key online artificial intelligence Mississippi"
                        },
                        new
                        {
                            Id = 36,
                            CreationDateTime = new DateTime(2021, 5, 2, 1, 42, 19, 914, DateTimeKind.Local).AddTicks(3633),
                            SeriesId = 54,
                            Title = "multi-byte generate Garden & Garden deposit"
                        },
                        new
                        {
                            Id = 37,
                            CreationDateTime = new DateTime(2021, 4, 3, 4, 45, 22, 755, DateTimeKind.Local).AddTicks(3434),
                            SeriesId = 337,
                            Title = "payment Implemented Paradigm programming"
                        },
                        new
                        {
                            Id = 38,
                            CreationDateTime = new DateTime(2020, 8, 6, 17, 22, 15, 658, DateTimeKind.Local).AddTicks(7140),
                            SeriesId = 609,
                            Title = "Architect Fresh Well calculating"
                        },
                        new
                        {
                            Id = 39,
                            CreationDateTime = new DateTime(2021, 3, 1, 23, 26, 15, 946, DateTimeKind.Local).AddTicks(2598),
                            SeriesId = 30,
                            Title = "Intranet transmit Administrator Small"
                        },
                        new
                        {
                            Id = 40,
                            CreationDateTime = new DateTime(2021, 3, 5, 10, 55, 15, 698, DateTimeKind.Local).AddTicks(745),
                            SeriesId = 153,
                            Title = "Concrete Fields Executive Up-sized"
                        },
                        new
                        {
                            Id = 41,
                            CreationDateTime = new DateTime(2021, 1, 29, 3, 37, 57, 97, DateTimeKind.Local).AddTicks(4772),
                            SeriesId = 51,
                            Title = "Investment Account payment Personal Loan Account Yuan Renminbi"
                        },
                        new
                        {
                            Id = 42,
                            CreationDateTime = new DateTime(2020, 11, 30, 1, 39, 36, 758, DateTimeKind.Local).AddTicks(4045),
                            SeriesId = 398,
                            Title = "Uruguay Bedfordshire Steel District"
                        },
                        new
                        {
                            Id = 43,
                            CreationDateTime = new DateTime(2020, 7, 5, 20, 44, 7, 379, DateTimeKind.Local).AddTicks(9730),
                            SeriesId = 764,
                            Title = "indigo HTTP Handmade Steel Salad District"
                        },
                        new
                        {
                            Id = 44,
                            CreationDateTime = new DateTime(2020, 7, 4, 11, 52, 41, 235, DateTimeKind.Local).AddTicks(7543),
                            SeriesId = 714,
                            Title = "Louisiana Networked Corporate green"
                        },
                        new
                        {
                            Id = 45,
                            CreationDateTime = new DateTime(2020, 8, 14, 23, 21, 38, 579, DateTimeKind.Local).AddTicks(7765),
                            SeriesId = 211,
                            Title = "Technician hack compress Unbranded"
                        },
                        new
                        {
                            Id = 46,
                            CreationDateTime = new DateTime(2020, 11, 2, 7, 37, 41, 221, DateTimeKind.Local).AddTicks(962),
                            SeriesId = 271,
                            Title = "New Caledonia Refined Rubber Soap Vermont Forward"
                        },
                        new
                        {
                            Id = 47,
                            CreationDateTime = new DateTime(2021, 2, 25, 4, 27, 27, 411, DateTimeKind.Local).AddTicks(7508),
                            SeriesId = 809,
                            Title = "Passage infrastructures Technician Licensed Concrete Pants"
                        },
                        new
                        {
                            Id = 48,
                            CreationDateTime = new DateTime(2020, 6, 27, 6, 37, 46, 907, DateTimeKind.Local).AddTicks(1033),
                            SeriesId = 243,
                            Title = "digital support Data backing up"
                        },
                        new
                        {
                            Id = 49,
                            CreationDateTime = new DateTime(2020, 7, 11, 17, 26, 37, 433, DateTimeKind.Local).AddTicks(3241),
                            SeriesId = 169,
                            Title = "experiences functionalities National Gateway"
                        },
                        new
                        {
                            Id = 50,
                            CreationDateTime = new DateTime(2020, 12, 30, 1, 43, 34, 932, DateTimeKind.Local).AddTicks(5781),
                            SeriesId = 728,
                            Title = "withdrawal Rustic calculate Mandatory"
                        });
                });

            modelBuilder.Entity("MoviesApis.Models.Series", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("MoviesApis.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("Duration")
                        .HasColumnType("float");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SeasonId")
                        .HasColumnType("int");

                    b.Property<string>("StoragePath")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.ToTable("Video");
                });

            modelBuilder.Entity("MoviesApis.Models.Season", b =>
                {
                    b.HasOne("MoviesApis.Models.Series", "Series")
                        .WithMany("Seasons")
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Series");
                });

            modelBuilder.Entity("MoviesApis.Models.Video", b =>
                {
                    b.HasOne("MoviesApis.Models.Season", "Season")
                        .WithMany("Episodes")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Season");
                });

            modelBuilder.Entity("MoviesApis.Models.Season", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("MoviesApis.Models.Series", b =>
                {
                    b.Navigation("Seasons");
                });
#pragma warning restore 612, 618
        }
    }
}