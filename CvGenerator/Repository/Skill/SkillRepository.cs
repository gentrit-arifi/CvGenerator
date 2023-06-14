using System.Collections.Generic;
using System.Linq;
using CvGenerator.Data;
using CvGenerator.Models;

namespace CvGenerator.Repositories
{
    public class SkillsRepository : ISkillsRepository
    {
        private readonly ApplicationDbContext _db;

        public SkillsRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Skills> GetAllSkills()
        {
            return _db.Skill.ToList();
        }

        public Skills GetSkillById(int id)
        {
            return _db.Skill.Find(id);
        }

        public void AddSkill(Skills skill)
        {
            _db.Skill.Add(skill);
            _db.SaveChanges();
        }

        public void UpdateSkill(Skills skill)
        {
            _db.Skill.Update(skill);
            _db.SaveChanges();
        }

        public void DeleteSkill(Skills skill)
        {
            _db.Skill.Remove(skill);
            _db.SaveChanges();
        }
    }
}