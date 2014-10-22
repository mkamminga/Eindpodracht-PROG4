using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EindProgOPdracht5.Models;

namespace ProgEindopdracht.Controllers
{
    public class RoomController : Controller
    {
        private HotelDbContext db = new HotelDbContext();

        //
        // GET: /Room/

        public ActionResult Index()
        { 
            return View(db.Rooms.Include(p => p.Price).ToList());
        }

        //
        // GET: /Room/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Room/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Room room)
        {
            if(db.Rooms.ToList().Count > 11)
            {
                ModelState.AddModelError("Error", "There cant be more then 12 rooms");
                return View();
            }

            if (ModelState.IsValid)
            {
                if (room.Price.Price == null)
                {
                    room.Price.Price = room.MinPrice;
                    room.Price.StartDate = null;
                    room.Price.EndDate = null;
                }                   

                if (room.Price.EndDate <= room.Price.StartDate)
                {
                    ModelState.AddModelError("Error", "End date must be after start date");
                    return View();
                }

                db.Rooms.Add(room);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(room);
        }

        //
        // GET: /Room/Edit/5

        public ActionResult Edit(int id = 0)
        {
            var room = db.Rooms.Include(p => p.Price).Single(p => p.RoomId == id);

            if (room == null)
            {
                return HttpNotFound();
            }
            return View(room);
        }

        //
        // POST: /Room/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Room room)
        {
            Room temp = db.Rooms.Find(room.RoomId);

            if(temp != null)
            {
                db.Rooms.Remove(temp);
                db.SaveChanges();
            }           

            if (ModelState.IsValid)
            {
                if (room.Price.Price == null)
                {
                    room.Price.Price = room.MinPrice;
                    room.Price.StartDate = null;
                    room.Price.EndDate = null;
                }

                if (room.Price.EndDate <= room.Price.StartDate)
                {
                    ModelState.AddModelError("Error", "End date must be after start date");
                    return View();
                }

                db.Rooms.Add(room);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(room);
        }

        //
        // GET: /Room/Delete/5

        public ActionResult Delete(int id = 0)
        {
            var room = db.Rooms.Include(p => p.Price).Single(p => p.RoomId == id);

            if (room == null)
            {
                return HttpNotFound();
            }
            return View(room);
        }

        //
        // POST: /Room/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Room room = db.Rooms.Find(id);
            db.Rooms.Remove(room);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}