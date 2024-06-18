﻿// <auto-generated />
using System;
using Csharpadvanced2024.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Csharpadvanced2024.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Gazania_krebsiana%2C_Quebec_city%2C_Quebec%2C_Canada_131.jpg/1280px-Gazania_krebsiana%2C_Quebec_city%2C_Quebec%2C_Canada_131.jpg"
                        },
                        new
                        {
                            Id = 3,
                            IsCover = false,
                            LandlordId = 1,
                            Url = "https://images.unsplash.com/photo-1500648767791-00dcc994a43e?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                        },
                        new
                        {
                            Id = 4,
                            IsCover = false,
                            LandlordId = 2,
                            Url = "https://images.unsplash.com/photo-1506794778202-cad84cf45f1d?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                        },
                        new
                        {
                            Id = 5,
                            IsCover = false,
                            LandlordId = 3,
                            Url = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
                        },
                        new
                        {
                            Id = 6,
                            IsCover = true,
                            LocationId = 3,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/Calle_Kirkegata%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_76.jpg/1920px-Calle_Kirkegata%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_76.jpg"
                        },
                        new
                        {
                            Id = 7,
                            IsCover = true,
                            LocationId = 4,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fd/Calle_Storgata%2C_Troms%C3%B8%2C_Noruega%2C_2019-09-04%2C_DD_69.jpg/1920px-Calle_Storgata%2C_Troms%C3%B8%2C_Noruega%2C_2019-09-04%2C_DD_69.jpg"
                        },
                        new
                        {
                            Id = 8,
                            IsCover = true,
                            LocationId = 4,
                            Url = "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Nav%C3%ADo_Costa_Pacifica_desde_Aksla,_%C3%85lesund,_Noruega,_2019-09-01,_DD_04.jpg"
                        },
                        new
                        {
                            Id = 9,
                            IsCover = true,
                            LocationId = 5,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Edificio_de_la_Asociaci%C3%B3n_de_Skippers%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_88.jpg/1920px-Edificio_de_la_Asociaci%C3%B3n_de_Skippers%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_88.jpg"
                        },
                        new
                        {
                            Id = 10,
                            IsCover = true,
                            LocationId = 5,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Escuela_Asp%C3%B8y_desde_Aksla%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_03.jpg/1920px-Escuela_Asp%C3%B8y_desde_Aksla%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_03.jpg"
                        },
                        new
                        {
                            Id = 11,
                            IsCover = true,
                            LocationId = 6,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Edificio_de_la_Asociaci%C3%B3n_de_Skippers%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_88.jpg/1920px-Edificio_de_la_Asociaci%C3%B3n_de_Skippers%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_88.jpg"
                        },
                        new
                        {
                            Id = 12,
                            IsCover = true,
                            LocationId = 6,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Escuela_Asp%C3%B8y_desde_Aksla%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_03.jpg/1920px-Escuela_Asp%C3%B8y_desde_Aksla%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_03.jpg"
                        },
                        new
                        {
                            Id = 13,
                            IsCover = true,
                            LocationId = 7,
                            Url = "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Escuela_Asp%C3%B8y,_%C3%85lesund,_Noruega,_2019-09-01,_DD_79.jpg"
                        },
                        new
                        {
                            Id = 14,
                            IsCover = true,
                            LocationId = 7,
                            Url = "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Escuela_Asp%C3%B8y,_%C3%85lesund,_Noruega,_2019-09-01,_DD_80.jpg"
                        },
                        new
                        {
                            Id = 15,
                            IsCover = true,
                            LocationId = 8,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Escuela_secundaria_Latinskolen%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_87.jpg/1280px-Escuela_secundaria_Latinskolen%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_87.jpg"
                        },
                        new
                        {
                            Id = 16,
                            IsCover = true,
                            LocationId = 8,
                            Url = "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Iglesia_parroquial,_%C3%85lesund,_Noruega,_2019-09-01,_DD_77.jpg"
                        },
                        new
                        {
                            Id = 17,
                            IsCover = true,
                            LocationId = 9,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Iglesia_parroquial%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_86.jpg/1280px-Iglesia_parroquial%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_86.jpg"
                        },
                        new
                        {
                            Id = 18,
                            IsCover = true,
                            LocationId = 9,
                            Url = "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Nav%C3%ADo_Costa_Pacifica_desde_Aksla,_%C3%85lesund,_Noruega,_2019-09-01,_DD_04.jpg"
                        },
                        new
                        {
                            Id = 19,
                            IsCover = true,
                            LocationId = 10,
                            Url = "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Nav%C3%ADo_Costa_Pacifica_desde_Aksla,_%C3%85lesund,_Noruega,_2019-09-01,_DD_04.jpg"
                        },
                        new
                        {
                            Id = 20,
                            IsCover = true,
                            LocationId = 10,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg/1920px-Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg"
                        },
                        new
                        {
                            Id = 21,
                            IsCover = true,
                            LocationId = 3,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg/1920px-Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg"
                        },
                        new
                        {
                            Id = 22,
                            IsCover = true,
                            LocationId = 2,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg/1920px-Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg"
                        },
                        new
                        {
                            Id = 23,
                            IsCover = true,
                            LocationId = 2,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg/1920px-Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg"
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
                            Age = 40,
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            Age = 33,
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

                    b.Property<int?>("LandlordId")
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

                    b.HasIndex("LandlordId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Genesteld in de bergen, biedt dit gezellige huisje een adembenemend uitzicht en een rustige sfeer. Perfect voor een weekendje weg.",
                            Features = 36,
                            LandlordId = 1,
                            NumberOfGuests = 6,
                            PricePerDay = 150f,
                            Rooms = 3,
                            Subtitle = "Rustig toevluchtsoord",
                            Title = "Rustiek Berg Huisje",
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Een stijlvol en modern appartement gelegen in het bruisende stadscentrum. Dicht bij alle belangrijke bezienswaardigheden en openbaar vervoer.",
                            Features = 12,
                            LandlordId = 2,
                            NumberOfGuests = 2,
                            PricePerDay = 200f,
                            Rooms = 2,
                            Subtitle = "In het hart van het centrum",
                            Title = "Modern Stadsappartement",
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
                        },
                        new
                        {
                            Id = 5,
                            Description = "Ervaar luxe in dit hotel aan het strand met een heerlijk bad en een adembenemend uitzicht op de oceaan. Perfect voor families en groepen.",
                            Features = 60,
                            LandlordId = 3,
                            NumberOfGuests = 8,
                            PricePerDay = 400f,
                            Rooms = 10,
                            Subtitle = "Luxe hotelverblijf met zeezicht",
                            Title = "Hotel aan het Strand",
                            Type = 4
                        },
                        new
                        {
                            Id = 6,
                            Description = "Een charmant huisje op het platteland, omgeven door groen. Ideaal voor een rustige vakantie met familie of vrienden.",
                            Features = 0,
                            LandlordId = 1,
                            NumberOfGuests = 5,
                            PricePerDay = 120f,
                            Rooms = 2,
                            Subtitle = "Charmant en rustig",
                            Title = "Gezellig Landelijk Huisje",
                            Type = 1
                        },
                        new
                        {
                            Id = 7,
                            Description = "Verblijf in een prachtig bewaard gebleven historisch huis met antieke meubels en moderne voorzieningen.",
                            Features = 29,
                            LandlordId = 2,
                            NumberOfGuests = 15,
                            PricePerDay = 400f,
                            Rooms = 7,
                            Subtitle = "Elegant en historisch",
                            Title = "Historisch Huis",
                            Type = 5
                        },
                        new
                        {
                            Id = 8,
                            Description = "Een stijlvolle kamer in het hart van de stad, met gemakkelijke toegang tot het nachtleven, eetgelegenheden en winkels.",
                            Features = 4,
                            LandlordId = 3,
                            NumberOfGuests = 2,
                            PricePerDay = 250f,
                            Rooms = 1,
                            Subtitle = "Stijlvol wonen in het centrum",
                            Title = "Stads Kamer",
                            Type = 3
                        },
                        new
                        {
                            Id = 9,
                            Description = "Een rustig chalet aan het meer, perfect voor vissen, kajakken en genieten van de natuur.",
                            Features = 5,
                            LandlordId = 1,
                            NumberOfGuests = 4,
                            PricePerDay = 180f,
                            Rooms = 2,
                            Subtitle = "Ontspannen bij het water",
                            Title = "Chalet aan het Meer",
                            Type = 2
                        },
                        new
                        {
                            Id = 10,
                            Description = "Het Grand Central Hotel biedt een perfecte combinatie van luxe en comfort. Gelegen in het hart van de stad, op loopafstand van de belangrijkste bezienswaardigheden, restaurants en winkels.",
                            Features = 36,
                            LandlordId = 1,
                            NumberOfGuests = 300,
                            PricePerDay = 150f,
                            Rooms = 10,
                            Subtitle = "Luxueus verblijf in het hart van de stad",
                            Title = "Grand Central Hotel",
                            Type = 4
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

            modelBuilder.Entity("Csharpadvanced2024.Models.Location", b =>
                {
                    b.HasOne("Csharpadvanced2024.Models.Landlord", "Landlord")
                        .WithMany("Locations")
                        .HasForeignKey("LandlordId");

                    b.Navigation("Landlord");
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

            modelBuilder.Entity("Csharpadvanced2024.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Csharpadvanced2024.Models.Landlord", b =>
                {
                    b.Navigation("Avatar");

                    b.Navigation("Locations");
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
