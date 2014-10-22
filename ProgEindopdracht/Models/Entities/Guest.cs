using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EindProgOPdracht5.Models.Entities
{
    public class Guest
    {
        public Guest()
        {
            Bookings = new List<Booking>();
        }
        [Key]
        public int GuestId { get; set; }
        [ForeignKey("Address")]
        public int? AddressId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Char Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}