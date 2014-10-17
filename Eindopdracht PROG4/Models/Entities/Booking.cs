using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eindopdracht_PROG4.Models.Entities
{
    public class Booking
    {
        public Booking()
        {
            Guests = new List<Guest>();
        }
        [Key]
        public int BookingId { get; set; }
        public int RoomId { get; set; }

        [ForeignKey("Address")]
        public int? InvoiceAddressId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Boolean? Confirmed { get; set; }
        public virtual ICollection<Guest>? Guests { get; set; }
        public virtual Room Room { get; set; }
        public virtual Address? InvoiceAddress { get; set; }
    }
}