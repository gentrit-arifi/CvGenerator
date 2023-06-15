using CvGenerator.Models;

namespace CvGenerator.Repository
{
    public interface IWorkExperienceRepository
    {
        IEnumerable<WorkExperiences> GetAllExp();
        WorkExperiences GetExpById(int id);
        void AddExp(WorkExperiences workExperiences);
        void UpdateExp(WorkExperiences workExperiences);
        void DeleteExp(WorkExperiences workExperiences);
    }
}
