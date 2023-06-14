using CvGenerator.Data;
using CvGenerator.Models;
using Microsoft.AspNetCore.Mvc;

namespace CvGenerator.Controllers
{
    public class ReferencesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ReferencesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<References> objRefList = _db.Reference;
            return View(objRefList);
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
            var refFromDb = _db.Reference.Find(id);

            if (refFromDb == null)
            {
                return NotFound();
            }
            return View(refFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(References obj)
        {
            if (ModelState.IsValid)
            {
                _db.Reference.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Reference created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(References obj)
        {
            if (ModelState.IsValid)
            {
                _db.Reference.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Reference updated successfully";
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
            var refFromDb = _db.Reference.Find(id);

            if (refFromDb == null)
            {
                return NotFound();
            }

            return View(refFromDb);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Reference.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Reference.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Reference deleted successfully";
            return RedirectToAction("Index");

        }
    }
}