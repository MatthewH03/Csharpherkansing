﻿using Csharpadvanced2024.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                      IsCover = true,
                      LandlordId = 1
                  }
             );

            modelBuilder.Entity<Landlord>().HasData
               (
                   new Landlord
                   {
                       Id = 1,
                       FirstName = "John",
                       LastName = "Doe",
                       Age = 55,
                   },

                   new Landlord
                   {
                       Id = 2,
                       FirstName = "Henk",
                       LastName = "Pieters",
                       Age = 40,
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
                        PricePerDay = 300,
                        Type = (Location.LocationType)0,
                        Features = 0,
                        Images = null,
                        Landlord = null,
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
                        Images = null,
                        Landlord = null,
                        Reservations = null
                    },

                    new Location {
                        Id = 4,
                        Title = "Frankie's Penthouse",
                        Subtitle = "Te gek uitzicht",
                        Description = "Nee, dit puike penthouse dat al jaren te koop stond en nu is verkocht, is niet de duurste woning van ons land. Bij lange na niet. Wel is de meer dan €30.000 per vierkante meter woonruimte een record in ons land.",
                        Rooms = 2,
                        NumberOfGuests = 4,
                        PricePerDay = 400,
                        Type = (Location.LocationType)0,
                        Features = 0,
                        Images = null,
                        Landlord = null,
                        Reservations = null
                    }
                ) ; 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=AIRDB;Integrated Security=SSPI;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
