using CvGenerator.Data;
using CvGenerator.Models;

namespace CvGenerator.Repository.CertificationAndTraining
{
    public class CertificationAndTrainingRepository:ICertificationAndTrainingRepository
    {
        private readonly ApplicationDbContext _db;

        public CertificationAndTrainingRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<CertificationAndTrainings> GetAllCer()
        {
            return _db.CertificationAndTrainings.ToList();
        }

        public CertificationAndTrainings GetCerById(int id)
        {
            return _db.CertificationAndTrainings.Find(id);
        }

        public void AddCer(CertificationAndTrainings certificationAndTrainings)
        {
            _db.CertificationAndTrainings.Add(certificationAndTrainings);
            _db.SaveChanges();
        }

        public void UpdateCer(CertificationAndTrainings certificationAndTrainings)
        {
            _db.CertificationAndTrainings.Update(certificationAndTrainings);
            _db.SaveChanges();
        }

        public void DeleteCer(CertificationAndTrainings certificationAndTrainings)
        {
            _db.CertificationAndTrainings.Remove(certificationAndTrainings);
            _db.SaveChanges();
        }
    }
}