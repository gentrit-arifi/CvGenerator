using CvGenerator.Data;
using CvGenerator.Models;

namespace CvGenerator.Repository.WorkExperience
{
    public class WorkExperienceRepository:IWorkExperienceRepository
    {
        private readonly ApplicationDbContext _db;

        public WorkExperienceRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<WorkExperiences> GetAllExp()
        {
            return _db.WorkExperiences.ToList();
        }

        public WorkExperiences GetExpById(int id)
        {
            return _db.WorkExperiences.Find(id);
        }

        public void AddExp(WorkExperiences workExperiences)
        {
            _db.WorkExperiences.Add(workExperiences);
            _db.SaveChanges();
        }

        public void UpdateExp(WorkExperiences workExperiences)
        {
            _db.WorkExperiences.Update(workExperiences);
            _db.SaveChanges();
        }

        public void DeleteExp(WorkExperiences workExperiences)
        {
            _db.WorkExperiences.Remove(workExperiences);
            _db.SaveChanges();
        }
    }
}