using System.Collections.Generic;
using System.Linq;
using CvGenerator.Data;
using CvGenerator.Models;

namespace CvGenerator.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly ApplicationDbContext _db;

        public SkillRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Skill> GetAllSkills()
        {
            return _db.Skill.ToList();
        }

        public Skill GetSkillById(int id)
        {
            return _db.Skill.Find(id);
        }

        public void AddSkill(Skill skill)
        {
            _db.Skill.Add(skill);
            _db.SaveChanges();
        }

        public void UpdateSkill(Skill skill)
        {
            _db.Skill.Update(skill);
            _db.SaveChanges();
        }

        public void DeleteSkill(Skill skill)
        {
            _db.Skill.Remove(skill);
            _db.SaveChanges();
        }
    }
}