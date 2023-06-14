using CvGenerator.Data;
using CvGenerator.Models;
using Microsoft.AspNetCore.Mvc;

namespace CvGenerator.Controllers
{
    public class CertificationAndTrainingController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CertificationAndTrainingController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<CertificationAndTraining> objCerList = _db.CertificationAndTrainings;
            return View(objCerList);
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
            var cerFromDb = _db.CertificationAndTrainings.Find(id);

            if (cerFromDb == null)
            {
                return NotFound();
            }
            return View(cerFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CertificationAndTraining obj)
        {
            if (ModelState.IsValid)
            {
                _db.CertificationAndTrainings.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Certification and Training created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CertificationAndTraining obj)
        {
            if (ModelState.IsValid)
            {
                _db.CertificationAndTrainings.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Certification and Training successfully";
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
            var cerFromDb = _db.CertificationAndTrainings.Find(id);

            if (cerFromDb == null)
            {
                return NotFound();
            }

            return View(cerFromDb);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.CertificationAndTrainings.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.CertificationAndTrainings.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Certification and Training deleted successfully";
            return RedirectToAction("Index");

        }
    }
}
