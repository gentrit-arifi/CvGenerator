using CvGenerator.Models;
using System.Collections.Generic;

namespace CvGenerator.Repositories
{
    public interface ISkillRepository
    {
        IEnumerable<Skill> GetAllSkills();
        Skill GetSkillById(int id);
        void AddSkill(Skill skill);
        void UpdateSkill(Skill skill);
        void DeleteSkill(Skill skill);
    }
}
