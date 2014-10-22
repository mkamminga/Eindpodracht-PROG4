using EindProgOPdracht5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgEindopdracht.Controllers
{
    public class HomeController : Controller
    {

        private HotelDbContext db = new HotelDbContext();
        public ActionResult Index()
        {
            db.Database.Delete();

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

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
