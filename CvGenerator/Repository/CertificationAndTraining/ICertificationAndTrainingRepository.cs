using CvGenerator.Models;

namespace CvGenerator.Repository.CertificationAndTraining
{
    public interface ICertificationAndTrainingRepository
    {
        IEnumerable<CertificationAndTrainings> GetAllCer();
        CertificationAndTrainings GetCerById(int id);
        void AddCer(CertificationAndTrainings certificationAndTrainings);
        void UpdateCer(CertificationAndTrainings certificationAndTrainings);
        void DeleteCer(CertificationAndTrainings certificationAndTrainings);
    }
}
