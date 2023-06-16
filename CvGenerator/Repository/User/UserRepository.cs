using CvGenerator.Data;
using CvGenerator.Models;

namespace CvGenerator.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Users> GetAllUsers()
        {
            return _db.Users.ToList();
        }

        public Users GetUserById(int id)
        {
            return _db.Users.Find(id);
        }

        public void AddUser(Users user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public void UpdateUser(Users user)
        {
            _db.Users.Update(user);
            _db.SaveChanges();
        }

        public void DeleteUser(Users user)
        {
            _db.Users.Remove(user);
            _db.SaveChanges();
        }
    }
}