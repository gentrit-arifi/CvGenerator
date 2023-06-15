using CvGenerator.Data;
using CvGenerator.Models;

namespace CvGenerator.Repository.Description
{
    public class DescriptionRepository:IDescriptionRepository
    {
        private readonly ApplicationDbContext _db;

        public DescriptionRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Descriptions> GetAllDes()
        {
            return _db.Descriptions.ToList();
        }

        public Descriptions GetDesById(int id)
        {
            return _db.Descriptions.Find(id);
        }

        public void AddDes(Descriptions descriptions)
        {
            _db.Descriptions.Add(descriptions);
            _db.SaveChanges();
        }

        public void UpdateDes(Descriptions descriptions)
        {
            _db.Descriptions.Update(descriptions);
            _db.SaveChanges();
        }

        public void DeleteDes(Descriptions descriptions)
        {
            _db.Descriptions.Remove(descriptions);
            _db.SaveChanges();
        }
    }
}