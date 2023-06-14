using CvGenerator.Models;

namespace CvGenerator.Repository
{
    public interface ICvRepository
    {
        List<User> GetUsers();

        bool AddUsers(List<User> users);
    }
}
