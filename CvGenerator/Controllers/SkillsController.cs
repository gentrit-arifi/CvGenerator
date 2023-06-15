using CvGenerator.Data;
using CvGenerator.Models;
using Microsoft.AspNetCore.Mvc;

namespace CvGenerator.Controllers
{
    public class SkillsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SkillsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Skill> objUserList = _db.Skill;
            return View(objUserList);
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
            var skillsFromDb = _db.Skill.Find(id);

            if (skillsFromDb == null)
            {
                return NotFound();
            }
            return View(skillsFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Skill obj)
        {
            if (ModelState.IsValid)
            {
                _db.Skill.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Skill obj)
        {
            if (ModelState.IsValid)
            {
                _db.Skill.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Skill updated successfully";
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
            var skillsFromDb = _db.Skill.Find(id);

            if (skillsFromDb == null)
            {
                return NotFound();
            }

            return View(skillsFromDb);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Skill.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Skill.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Skill deleted successfully";
            return RedirectToAction("Index");

        }
    }
}
