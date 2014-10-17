using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Eindopdracht_PROG4.Models.Entities;

namespace Eindopdracht_PROG4.Models
{
    public class MyEntityContext : DbContext
    {
        public MyEntityContext() : base("DefaultConnection") { }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}