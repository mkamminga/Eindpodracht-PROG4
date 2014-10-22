using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EindProgOPdracht5.Models.Entities;

namespace EindProgOPdracht5.Models
{
    public class MyEntityContext : DbContext
    {
        public MyEntityContext() : base("DefaultConnection") { }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}