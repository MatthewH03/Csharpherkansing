﻿// <auto-generated />
using System;
using Csharpadvanced2024.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240530090841_add second image to location1")]
    partial class addsecondimagetolocation1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Csharpadvanced2024.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsCover")
                        .HasColumnType("bit");

                    b.Property<int?>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LandlordId");

                    b.HasIndex("LocationId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsCover = true,
                            LocationId = 1,
                            Url = "https://d7hftxdivxxvm.cloudfront.net/?height=630&quality=80&resize_to=fill&src=https%3A%2F%2Fartsy-media-uploads.s3.amazonaws.com%2F2P6t_Yt6dF0TNN76dlp-_Q%252F3417757448_4a6bdf36ce_o.jpg&width=1200"
                        },
                        new
                        {
                            Id = 2,
                            IsCover = true,
                            LocationId = 1,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/2011_Berat%2C_Cerkiew_%C5%9Bw._Teodora.JPG/1024px-2011_Berat%2C_Cerkiew_%C5%9Bw._Teodora.JPG"
                        });
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Landlord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Landlords");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 55,
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            Age = 40,
                            FirstName = "Henk",
                            LastName = "Pieters"
                        },
                        new
                        {
                            Id = 3,
                            Age = 36,
                            FirstName = "Jan",
                            LastName = "Hollands"
                        });
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Features")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<float>("PricePerDay")
                        .HasColumnType("real");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Dit is de eerste locatie",
                            Features = 0,
                            NumberOfGuests = 10,
                            PricePerDay = 300f,
                            Rooms = 5,
                            Subtitle = "Mooie locatie",
                            Title = "Locatie nr. 1",
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            Description = "De camping ligt verscholen achter de boerderij in de polder. Op fietsafstand (5 minuten) liggen het dorpje Nieuwvliet, de zee, het strand, het bos van Erasmus en het natuurgebied de Knokkert.",
                            Features = 0,
                            NumberOfGuests = 12,
                            PricePerDay = 300f,
                            Rooms = 5,
                            Subtitle = "Lekker veel ruimte",
                            Title = "De Boerenhoeve",
                            Type = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Nee, dit puike penthouse dat al jaren te koop stond en nu is verkocht, is niet de duurste woning van ons land. Bij lange na niet. Wel is de meer dan €30.000 per vierkante meter woonruimte een record in ons land.",
                            Features = 0,
                            NumberOfGuests = 4,
                            PricePerDay = 400f,
                            Rooms = 2,
                            Subtitle = "Te gek uitzicht",
                            Title = "Frankie's Penthouse",
                            Type = 0
                        });
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("LandlordLocation", b =>
                {
                    b.Property<int>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int>("LocationsId")
                        .HasColumnType("int");

                    b.HasKey("LandlordId", "LocationsId");

                    b.HasIndex("LocationsId");

                    b.ToTable("LandlordLocation");
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Image", b =>
                {
                    b.HasOne("Csharpadvanced2024.Models.Landlord", "Landlord")
                        .WithMany("Avatar")
                        .HasForeignKey("LandlordId");

                    b.HasOne("Csharpadvanced2024.Models.Location", "Location")
                        .WithMany("Images")
                        .HasForeignKey("LocationId");

                    b.Navigation("Landlord");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Reservation", b =>
                {
                    b.HasOne("Csharpadvanced2024.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Csharpadvanced2024.Models.Location", null)
                        .WithMany("Reservations")
                        .HasForeignKey("LocationId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("LandlordLocation", b =>
                {
                    b.HasOne("Csharpadvanced2024.Models.Landlord", null)
                        .WithMany()
                        .HasForeignKey("LandlordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Csharpadvanced2024.Models.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Landlord", b =>
                {
                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Location", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
