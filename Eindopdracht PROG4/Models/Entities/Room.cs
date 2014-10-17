using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Eindopdracht_PROG4.Models.Entities
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public int Number { get; set; }
        public double Price { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}