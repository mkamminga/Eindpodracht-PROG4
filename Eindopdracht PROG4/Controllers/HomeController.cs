using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eindopdracht_PROG4.Models;
using Eindopdracht_PROG4.Models.Entities;

namespace Eindopdracht_PROG4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EntityRooms entityRooms         = new EntityRooms();
            EntityBookings entityBookings   = new EntityBookings();
            //Create room
            Room room = new Room();
            room.Number = 1;
            room.Price = 20.89;

            entityRooms.Add(room);
            //Create address for furture use
            Address guestAddress = new Address();
            guestAddress.Street = "Ruiters";
            guestAddress.HouseNumber = "1b";
            guestAddress.Residence = "Hilversum";
            guestAddress.Zip = "1211KW";
            guestAddress.Email = "mjkammin@student.avans.nl";
            //Guest to be added to the booking
            Guest guest = new Guest();
            guest.Address = guestAddress;
            guest.FirstName = "M";
            guest.LastName = "Kamminga";
            guest.Gender = 'm';
            guest.BirthDate = DateTime.Now.AddDays(-20);
            
            Booking booking = new Booking();
            booking.Room = room;
            booking.StartDate = DateTime.Now;
            booking.EndDate = DateTime.Now;
            //Nullable collection, Value.Add instead of Add 
            booking.Guests.Value.Add(guest);
            booking.Confirmed = true;
            booking.InvoiceAddress = guestAddress;
            entityBookings.Add(booking);
            
            //New
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application. RoomId: " + room.RoomId  ;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
