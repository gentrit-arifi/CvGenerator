using CvGenerator.Data;
using CvGenerator.Models;
using Microsoft.AspNetCore.Mvc;

namespace CvGenerator.Controllers
{
    public class WorkExperienceController : Controller
    {
            private readonly ApplicationDbContext _db;

            public WorkExperienceController(ApplicationDbContext db)
            {
                _db = db;
            }
            public IActionResult Index()
            {
                IEnumerable<WorkExperience> objExpList = _db.WorkExperiences;
                return View(objExpList);
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
                var expFromDb = _db.WorkExperiences.Find(id);

                if (expFromDb == null)
                {
                    return NotFound();
                }
                return View(expFromDb);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create(WorkExperience obj)
            {
                if (ModelState.IsValid)
                {
                    _db.WorkExperiences.Add(obj);
                    _db.SaveChanges();
                    TempData["success"] = "Work Experience created successfully";
                    return RedirectToAction("Index");
                }
                return View(obj);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Edit(WorkExperience obj)
            {
                if (ModelState.IsValid)
                {
                    _db.WorkExperiences.Update(obj);
                    _db.SaveChanges();
                    TempData["success"] = "Work Ecperience updated successfully";
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
                var expFromDb = _db.WorkExperiences.Find(id);

                if (expFromDb == null)
                {
                    return NotFound();
                }

                return View(expFromDb);
            }

            //POST
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public IActionResult DeletePOST(int? id)
            {
                var obj = _db.WorkExperiences.Find(id);
                if (obj == null)
                {
                    return NotFound();
                }

                _db.WorkExperiences.Remove(obj);
                _db.SaveChanges();
                TempData["success"] = "Work Experience deleted successfully";
                return RedirectToAction("Index");

            }
        }
    }
