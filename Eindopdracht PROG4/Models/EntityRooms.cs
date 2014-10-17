using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Eindopdracht_PROG4.Models.Entities;

namespace Eindopdracht_PROG4.Models
{
    public class EntityRooms
    {
         private MyEntityContext dbContext;

         public EntityRooms()
        {
            dbContext = new MyEntityContext();
        }

        public List<Room> getAll()
        {
            return dbContext.Rooms.ToList();
        }

        public void Add(Room room)
        {
            dbContext.Rooms.Add(room);
            dbContext.SaveChanges();
        }
    }
}