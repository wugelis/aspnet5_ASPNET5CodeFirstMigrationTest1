using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using MyCodeFiratAPNET5.Models;

namespace MyCodeFiratAPNET5.Controllers
{
    public class ClassRoomController : Controller
    {
        private ClassRoomContext db = new ClassRoomContext();

        // GET: ClassRoom
        public IActionResult Index()
        {
            return View(db.ClassRooms.ToList());
        }

        // GET: ClassRoom/Details/5
        public IActionResult Details(System.Int32? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(404);
            }

            ClassRoom classRoom = db.ClassRooms.Single(m => m.id == id);
            if (classRoom == null)
            {
                return new HttpStatusCodeResult(404);
            }

            return View(classRoom);
        }

        // GET: ClassRoom/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClassRoom/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ClassRoom classRoom)
        {
            if (ModelState.IsValid)
            {
                db.ClassRooms.Add(classRoom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classRoom);
        }

        // GET: ClassRoom/Edit/5
        public IActionResult Edit(System.Int32? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(404);
            }

            ClassRoom classRoom = db.ClassRooms.Single(m => m.id == id);
            if (classRoom == null)
            {
                return new HttpStatusCodeResult(404);
            }

            return View(classRoom);
        }

        // POST: ClassRoom/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ClassRoom classRoom)
        {
            if (ModelState.IsValid)
            {
                db.Update(classRoom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classRoom);
        }

        // GET: ClassRoom/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(System.Int32? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(404);
            }

            ClassRoom classRoom = db.ClassRooms.Single(m => m.id == id);
            if (classRoom == null)
            {
                return new HttpStatusCodeResult(404);
            }

            return View(classRoom);
        }

        // POST: ClassRoom/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(System.Int32 id)
        {
            ClassRoom classRoom = db.ClassRooms.Single(m => m.id == id);
            db.ClassRooms.Remove(classRoom);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
