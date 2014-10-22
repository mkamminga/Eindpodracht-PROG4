using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Eindopdracht_PROG4.Models.Entities;

namespace Eindopdracht_PROG4.Models.ViewModels
{
    public class BookingViewModel
    {
        public BookingViewModel(Booking booking)
        {
            Rooms = new List<Room>();

            if (booking != null)
            {

            } 
        }
        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public List<Room> Rooms { get; set; } 
        public int? InvoiceAddressId { get; set; }
        public DateTime StartDate
        {
            get;
            set;
        }
        public DateTime EndDate { get; set; }
        public Boolean? Confirmed { get; set; }
        public virtual ICollection<Guest> Guests { get; set; }
        public virtual Room Room { get; set; }
        public virtual Address InvoiceAddress { get; set; }
    }
}