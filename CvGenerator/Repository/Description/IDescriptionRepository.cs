using CvGenerator.Models;

namespace CvGenerator.Repository.Description
{
    public interface IDescriptionRepository
    {
        IEnumerable<Descriptions> GetAllDes();
        Descriptions GetDesById(int id);
        void AddDes(Descriptions descriptions);
        void UpdateDes(Descriptions descriptions);
        void DeleteDes(Descriptions descriptions);
    }
}
