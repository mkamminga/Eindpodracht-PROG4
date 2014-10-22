using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EindProgOPdracht5.Models;
using EindProgOPdracht5.Models.Entities;
using EindProgOPdracht5.Models.ViewModels;

namespace Eindopdracht_PROG4.Controllers
{
    public class BookingController : Controller
    {
        private EntityBookings entityBooking    = new EntityBookings();
        private EntityRooms entityRooms         = new EntityRooms();
        //
        // GET: /Booking/

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            BookingViewModel bVm = new BookingViewModel(null);
            bVm.Rooms = entityRooms.getAll();

            return View(bVm);
        }
        [HttpPost]
        public ActionResult Add(Booking booking)
        {
            return View();
        }

        public ActionResult AddGuests(int bookingId)
        {
            return View();
        }

        public ActionResult Confirm(int bookingId)
        {
            return View();
        }

    }
}
