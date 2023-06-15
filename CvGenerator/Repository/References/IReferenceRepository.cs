using CvGenerator.Models;

namespace CvGenerator.Repository.References
{
    public interface IReferenceRepository
    {
        IEnumerable<Reference> GetAllRef();
        Reference GetRefById(int id);
        void AddRef(Reference reference);
        void UpdateRef(Reference reference);
        void DeleteRef(Reference reference);
    }
}
