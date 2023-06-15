using CvGenerator.Data;
using CvGenerator.Models;
using CvGenerator.Repositories;

namespace CvGenerator.Repository.Education
{
    public class EducationRepository : IEducationRepository
    {
        private readonly ApplicationDbContext _db;

        public EducationRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Educations> GetAllEdu()
        {
            return _db.Educations.ToList();
        }

        public Educations GetEduById(int id)
        {
            return _db.Educations.Find(id);
        }

        public void AddEdu(Educations educations)
        {
            _db.Educations.Add(educations);
            _db.SaveChanges();
        }

        public void UpdateEdu(Educations educations)
        {
            _db.Educations.Update(educations);
            _db.SaveChanges();
        }

        public void DeleteEdu(Educations educations)
        {
            _db.Educations.Remove(educations);
            _db.SaveChanges();
        }
    }
}