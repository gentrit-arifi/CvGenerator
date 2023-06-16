using CvGenerator.Data;
using CvGenerator.Models;
using Microsoft.AspNetCore.Mvc;

namespace CvGenerator.Controllers
{
    public class EducationController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EducationController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Education";
            IEnumerable<Educations> objEduList = _db.Educations;
            return View(objEduList);
        }
        public IActionResult Create()
        {

            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var eduFromDb = _db.Educations.Find(id);

            if (eduFromDb == null)
            {
                return NotFound();
            }
            return View(eduFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Educations obj)
        {
            if (ModelState.IsValid)
            {
                _db.Educations.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Education created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Educations obj)
        {
            if (ModelState.IsValid)
            {
                _db.Educations.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Education updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var eduFromDb = _db.Educations.Find(id);

            if (eduFromDb == null)
            {
                return NotFound();
            }

            return View(eduFromDb);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Educations.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Educations.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Education deleted successfully";
            return RedirectToAction("Index");

        }
    }
}
