using CvGenerator.Data;
using CvGenerator.Models;
using Microsoft.EntityFrameworkCore;

namespace CvGenerator.Repository
{
    public class CvRepository : ICvRepository
    {
        private ApplicationDbContext _db;

        public CvRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool AddUsers(List<User> users)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            var users = _db.Users
                .Include(x => x.FirstName)
                .Include(x => x.LastName)
                .Include(x => x.BirthDate)
                .Include(x => x.PhoneNumber)
                .Include(x => x.Email)
                .Include(x => x.Address)
                .ToList();

            return users;
        }

        public List<Skills> GetSkills()
        {
            var skill = _db.Skill
                .Include(x => x.Name)
                .Include(x => x.Description)
                .ToList();

            return skill;
        }
    }
}