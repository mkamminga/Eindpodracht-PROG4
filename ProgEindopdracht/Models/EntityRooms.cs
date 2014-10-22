using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EindProgOPdracht5.Models.Entities;

namespace EindProgOPdracht5.Models
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