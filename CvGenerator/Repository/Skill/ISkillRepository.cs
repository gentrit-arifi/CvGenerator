using CvGenerator.Models;
using System.Collections.Generic;

namespace CvGenerator.Repositories
{
    public interface ISkillsRepository
    {
        IEnumerable<Skills> GetAllSkills();
        Skills GetSkillById(int id);
        void AddSkill(Skills skill);
        void UpdateSkill(Skills skill);
        void DeleteSkill(Skills skill);
    }
}
