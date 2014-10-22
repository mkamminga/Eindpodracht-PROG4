﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EindProgOPdracht5.Models;

namespace EindProgOPdracht5.Models
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }

        public DbSet<RoomPrice> Prices { get; set; }

    }
}