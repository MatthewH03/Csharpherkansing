﻿using Csharpadvanced2024.Models;
using Microsoft.EntityFrameworkCore;

namespace Csharpadvanced2024.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Landlord> Landlords { get; set; }
        public DbSet<Location> Locations { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().HasData
             (
                 new Image
                 {
                     Id = 1,
                     Url = "https://d7hftxdivxxvm.cloudfront.net/?height=630&quality=80&resize_to=fill&src=https%3A%2F%2Fartsy-media-uploads.s3.amazonaws.com%2F2P6t_Yt6dF0TNN76dlp-_Q%252F3417757448_4a6bdf36ce_o.jpg&width=1200",
                     IsCover = true,
                     LocationId = 1
                 },

                  new Image
                  {
                      Id = 2,
                      Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Gazania_krebsiana%2C_Quebec_city%2C_Quebec%2C_Canada_131.jpg/1280px-Gazania_krebsiana%2C_Quebec_city%2C_Quebec%2C_Canada_131.jpg",
                      IsCover = true,
                      LocationId = 1
                  },

                  new Image
                  {
                      Id = 3,
                      Url = "https://images.unsplash.com/photo-1500648767791-00dcc994a43e?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                      IsCover = false,
                      LandlordId = 1
                  },

                  new Image
                  {
                      Id = 4,
                      Url = "https://images.unsplash.com/photo-1506794778202-cad84cf45f1d?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                      IsCover = false,
                      LandlordId = 2
                  },

                  new Image
                  {
                      Id = 5,
                      Url = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                      IsCover = false,
                      LandlordId = 3
                  },

                  new Image
                  {
                      Id = 6,
                      Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/Calle_Kirkegata%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_76.jpg/1920px-Calle_Kirkegata%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_76.jpg",
                      IsCover = true,
                      LocationId = 3
                  },

                  new Image
                  {
                      Id = 7,
                      Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fd/Calle_Storgata%2C_Troms%C3%B8%2C_Noruega%2C_2019-09-04%2C_DD_69.jpg/1920px-Calle_Storgata%2C_Troms%C3%B8%2C_Noruega%2C_2019-09-04%2C_DD_69.jpg",
                      IsCover = true,
                      LocationId = 4
                  },

                  new Image
                  {
                      Id = 8,
                      Url = "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Nav%C3%ADo_Costa_Pacifica_desde_Aksla,_%C3%85lesund,_Noruega,_2019-09-01,_DD_04.jpg",
                      IsCover = true,
                      LocationId = 4
                  },

                  new Image
                  {
                      Id = 9,
                      Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Edificio_de_la_Asociaci%C3%B3n_de_Skippers%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_88.jpg/1920px-Edificio_de_la_Asociaci%C3%B3n_de_Skippers%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_88.jpg",
                      IsCover = true,
                      LocationId = 5
                  },

                  new Image
                  {
                      Id = 10,
                      Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Escuela_Asp%C3%B8y_desde_Aksla%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_03.jpg/1920px-Escuela_Asp%C3%B8y_desde_Aksla%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_03.jpg",
                      IsCover = true,
                      LocationId = 5
                  },

                  new Image
                  {
                      Id = 11,
                      Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Edificio_de_la_Asociaci%C3%B3n_de_Skippers%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_88.jpg/1920px-Edificio_de_la_Asociaci%C3%B3n_de_Skippers%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_88.jpg",
                      IsCover = true,
                      LocationId = 6
                  },

                  new Image
                  {
                      Id = 12,
                      Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Escuela_Asp%C3%B8y_desde_Aksla%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_03.jpg/1920px-Escuela_Asp%C3%B8y_desde_Aksla%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_03.jpg",
                      IsCover = true,
                      LocationId = 6
                  },

                  new Image
                  {
                      Id = 13,
                      Url = "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Escuela_Asp%C3%B8y,_%C3%85lesund,_Noruega,_2019-09-01,_DD_79.jpg",
                      IsCover = true,
                      LocationId = 7
                  },

                  new Image
                  {
                      Id = 14,
                      Url = "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Escuela_Asp%C3%B8y,_%C3%85lesund,_Noruega,_2019-09-01,_DD_80.jpg",
                      IsCover = true,
                      LocationId = 7
                  },

                  new Image
                  {
                      Id = 15,
                      Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Escuela_secundaria_Latinskolen%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_87.jpg/1280px-Escuela_secundaria_Latinskolen%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_87.jpg",
                      IsCover = true,
                      LocationId = 8
                  },

                  new Image
                  {
                      Id = 16,
                      Url = "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Iglesia_parroquial,_%C3%85lesund,_Noruega,_2019-09-01,_DD_77.jpg",
                      IsCover = true,
                      LocationId = 8
                  },

                  new Image
                  {
                      Id = 17,
                      Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Iglesia_parroquial%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_86.jpg/1280px-Iglesia_parroquial%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_86.jpg",
                      IsCover = true,
                      LocationId = 9
                  },

                  new Image
                  {
                      Id = 18,
                      Url = "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Nav%C3%ADo_Costa_Pacifica_desde_Aksla,_%C3%85lesund,_Noruega,_2019-09-01,_DD_04.jpg",
                      IsCover = true,
                      LocationId = 9
                  },

                  new Image
                  {
                      Id = 19,
                      Url = "https://commons.wikimedia.org/wiki/Category:Quality_images_of_%C3%85lesund#/media/File:Nav%C3%ADo_Costa_Pacifica_desde_Aksla,_%C3%85lesund,_Noruega,_2019-09-01,_DD_04.jpg",
                      IsCover = true,
                      LocationId = 10
                  },

                  new Image
                  {
                      Id = 20,
                      Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg/1920px-Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg",
                      IsCover = true,
                      LocationId = 10
                  },

                  new Image
                  {
                      Id = 21,
                      Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg/1920px-Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg",
                      IsCover = true,
                      LocationId = 3
                  },

                  new Image
                  {
                      Id = 22,
                      Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg/1920px-Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg",
                      IsCover = true,
                      LocationId = 2
                  },

                  new Image
                  {
                      Id = 23,
                      Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg/1920px-Puerto%2C_%C3%85lesund%2C_Noruega%2C_2019-09-01%2C_DD_36-40_PAN.jpg",
                      IsCover = true,
                      LocationId = 2
                  }
             );

            modelBuilder.Entity<Landlord>().HasData
               (
                   new Landlord
                   {
                       Id = 1,
                       FirstName = "John",
                       LastName = "Doe",
                       Age = 40,
                   },

                   new Landlord
                   {
                       Id = 2,
                       FirstName = "Henk",
                       LastName = "Pieters",
                       Age = 33,
                   },

                   new Landlord
                   {
                       Id = 3,
                       FirstName = "Jan",
                       LastName = "Hollands",
                       Age = 36,
                   }
               );

            modelBuilder.Entity<Location>().HasData
                (
                    new Location
                    {
                        Id = 1,
                        Title = "Locatie nr. 1",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de eerste locatie",
                        Rooms = 5,
                        NumberOfGuests = 10,
                        PricePerDay = 100,
                        Type = Location.LocationType.Appartment,
                        Features = Location.FeaturesEnum.Smoking,
                        LandlordId = 1,
                        Reservations = null
                    },

                     new Location
                     {
                         Id = 2,
                         Title = "Locatie nr. 2",
                         Subtitle = "Mooie locatie",
                         Description = "Dit is de tweede locatie",
                         Rooms = 5,
                         NumberOfGuests = 10,
                         PricePerDay = 300,
                         Type = Location.LocationType.Cottage,
                         Features = Location.FeaturesEnum.PetsAllowed,
                         LandlordId = 2,
                         Reservations = null
                     },

                    new Location
                    {
                        Id = 3,
                        Title = "De Boerenhoeve",
                        Subtitle = "Lekker veel ruimte",
                        Description = "De camping ligt verscholen achter de boerderij in de polder. Op fietsafstand (5 minuten) liggen het dorpje Nieuwvliet, de zee, het strand, het bos van Erasmus en het natuurgebied de Knokkert.",
                        Rooms = 5,
                        NumberOfGuests = 12,
                        PricePerDay = 300,
                        Type = (Location.LocationType)1,
                        Features = 0,
                        LandlordId = null,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 4,
                        Title = "Frankie's Penthouse",
                        Subtitle = "Te gek uitzicht",
                        Description = "Nee, dit puike penthouse dat al jaren te koop stond en nu is verkocht, is niet de duurste woning van ons land. Bij lange na niet. Wel is de meer dan €30.000 per vierkante meter woonruimte een record in ons land.",
                        Rooms = 2,
                        NumberOfGuests = 4,
                        PricePerDay = 400,
                        Type = (Location.LocationType)0,
                        Features = 0,
                        LandlordId = null,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 5,
                        Title = "Locatie nr. 5",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de vijfde locatie",
                        Rooms = 3,
                        NumberOfGuests = 5,
                        PricePerDay = 200,
                        Type = Location.LocationType.Chalet,
                        Features = Location.FeaturesEnum.Wifi,
                        LandlordId = 3,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 6,
                        Title = "Locatie nr. 6",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de zesde locatie",
                        Rooms = 6,
                        NumberOfGuests = 6,
                        PricePerDay = 400,
                        Type = Location.LocationType.Hotel,
                        Features = Location.FeaturesEnum.TV,
                        LandlordId = 1,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 7,
                        Title = "Locatie nr. 7",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de zevende locatie",
                        Rooms = 7,
                        NumberOfGuests = 7,
                        PricePerDay = 100,
                        Type = Location.LocationType.House,
                        Features = Location.FeaturesEnum.Bath,
                        LandlordId = 2,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 8,
                        Title = "Locatie nr. 8",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de achtste locatie",
                        Rooms = 8,
                        NumberOfGuests = 8,
                        PricePerDay = 300,
                        Type = Location.LocationType.Appartment,
                        Features = Location.FeaturesEnum.Breakfast,
                        LandlordId = 3,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 9,
                        Title = "Locatie nr. 9",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de negenste locatie",
                        Rooms = 9,
                        NumberOfGuests = 9,
                        PricePerDay = 200,
                        Type = Location.LocationType.Appartment,
                        Features = Location.FeaturesEnum.PetsAllowed,
                        LandlordId = 1,
                        Reservations = null
                    },

                    new Location
                    {
                        Id = 10,
                        Title = "Locatie nr. 10",
                        Subtitle = "Mooie locatie",
                        Description = "Dit is de tiende locatie",
                        Rooms = 3,
                        NumberOfGuests = 10,
                        PricePerDay = 400,
                        Type = Location.LocationType.Cottage,
                        Features = Location.FeaturesEnum.Wifi,
                        LandlordId = null,
                        Reservations = null
                    }
                );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=AIRDB;Integrated Security=SSPI;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
