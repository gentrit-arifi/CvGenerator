using CvGenerator.Models;
using System.Collections.Generic;

namespace CvGenerator.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<Users> GetAllUsers();
        Users GetUserById(int id);
        void AddUser(Users user);
        void UpdateUser(Users user);
        void DeleteUser(Users user);
    }
}
