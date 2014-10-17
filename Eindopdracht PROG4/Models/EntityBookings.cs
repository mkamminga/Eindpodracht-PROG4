using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Eindopdracht_PROG4.Models.Entities;

namespace Eindopdracht_PROG4.Models
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