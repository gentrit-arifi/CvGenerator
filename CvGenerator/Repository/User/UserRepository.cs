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

        public IEnumerable<User> GetAllUsers()
        {
            return _db.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _db.Users.Find(id);
        }

        public void AddUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _db.Users.Update(user);
            _db.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            _db.Users.Remove(user);
            _db.SaveChanges();
        }
    }
}