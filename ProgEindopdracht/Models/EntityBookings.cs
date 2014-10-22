using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EindProgOPdracht5.Models.Entities;

namespace EindProgOPdracht5.Models
{
    public class EntityBookings
    {
        private MyEntityContext dbContext;

        public EntityBookings()
        {
            dbContext = new MyEntityContext();
        }

        public List<Booking> getAll()
        {
            return dbContext.Bookings.ToList();
        }

        public void Add(Booking booking)
        {
            dbContext.Bookings.Add(booking);
            dbContext.SaveChanges();
        }
    }
}