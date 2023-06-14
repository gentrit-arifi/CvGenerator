using CvGenerator.Data;
using CvGenerator.Models;
using Microsoft.AspNetCore.Mvc;

namespace CvGenerator.Controllers
{
    public class DescriptionController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DescriptionController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Description> objDesList = _db.Descriptions;
            return View(objDesList);
        }
        public IActionResult Create()
        {
            if (_db.Descriptions.Any())
            {
                ViewBag.DisableCreate = true;
            }
            else
            {
                ViewBag.DisableCreate = false;
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var desFromDb = _db.Descriptions.Find(id);

            if (desFromDb == null)
            {
                return NotFound();
            }
            return View(desFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Description obj)
        {
            if (ModelState.IsValid)
            {
                _db.Descriptions.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Description created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Description obj)
        {
            if (ModelState.IsValid)
            {
                _db.Descriptions.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Description updated successfully";
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
            var desFromDb = _db.Descriptions.Find(id);

            if (desFromDb == null)
            {
                return NotFound();
            }

            return View(desFromDb);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Descriptions.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Descriptions.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Description deleted successfully";
            return RedirectToAction("Index");

        }
    }
}
