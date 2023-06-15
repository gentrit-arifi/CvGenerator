using CvGenerator.Data;
using CvGenerator.Models;

namespace CvGenerator.Repository.References
{
    public class ReferenceRepository:IReferenceRepository
    {
        private readonly ApplicationDbContext _db;

        public ReferenceRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Reference> GetAllRef()
        {
            return _db.Reference.ToList();
        }

        public Reference GetRefById(int id)
        {
            return _db.Reference.Find(id);
        }

        public void AddRef(Reference reference)
        {
            _db.Reference.Add(reference);
            _db.SaveChanges();
        }

        public void UpdateRef(Reference reference)
        {
            _db.Reference.Update(reference);
            _db.SaveChanges();
        }

        public void DeleteRef(Reference reference)
        {
            _db.Reference.Remove(reference);
            _db.SaveChanges();
        }
    }
}