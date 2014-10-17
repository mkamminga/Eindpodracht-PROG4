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

            Room room = new Room();
            room.Number = 1;
            room.Price = 20.89;

            entityRooms.Add(room);

            Booking booking = new Booking();
            booking.Room = room;
            booking.StartDate = DateTime.Now;
            booking.EndDate = DateTime.Now;
           
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
