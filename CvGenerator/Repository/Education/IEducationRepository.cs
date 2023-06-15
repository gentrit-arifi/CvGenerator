
using CvGenerator.Models;

namespace CvGenerator.Repository
{
    public interface IEducationRepository
    {
        IEnumerable<Educations> GetAllEdu();
        Educations GetEduById(int id);
        void AddEdu(Educations educations);
        void UpdateEdu(Educations educations);
        void DeleteEdu(Educations educations);
    }
}

